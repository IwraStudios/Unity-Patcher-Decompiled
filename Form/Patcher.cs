using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

public class Patcher
{
	public class Pattern
	{
		public class Place
		{
			public long bufferPos;

			public int position;

			public Place()
			{
				this.bufferPos = 0L;
				this.position = 0;
			}
		}

		public int replaceAfter;

		public int brakAfter;

		public List<byte[]> search;

		public List<byte[]> replace;

		private List<Patcher.Pattern.Place> rePl;

		private bool valid;

		private bool replaceImm;

		private string state;

		public bool ValidPattern
		{
			get
			{
				return this.valid;
			}
		}

		public bool ReplaceImmediately
		{
			get
			{
				return this.replaceImm;
			}
		}

		public string CurState
		{
			get
			{
				return this.state;
			}
		}

		public List<Patcher.Pattern.Place> AllPlaces
		{
			get
			{
				return this.rePl;
			}
		}

		public int FindCount
		{
			get
			{
				return this.rePl.Count;
			}
		}

		public bool SuccesFind
		{
			get
			{
				bool result;
				if (this.brakAfter == -1)
				{
					result = (this.FindCount > 0);
				}
				else
				{
					result = (this.MustFind() == this.rePl.Count);
				}
				return result;
			}
		}

		public Pattern()
		{
			this.replaceAfter = 0;
			this.brakAfter = 1;
			this.search = new List<byte[]>();
			this.replace = new List<byte[]>();
			this.rePl = new List<Patcher.Pattern.Place>();
			this.state = string.Empty;
		}

		public int MustFind()
		{
			return checked(this.brakAfter - this.replaceAfter);
		}

		public bool AddPlace(long bp, int po)
		{
            Patcher.Pattern.Place place = new Patcher.Pattern.Place()
            {
                bufferPos = bp,
                position = po
            };
            this.rePl.Add(place);
			return true;
		}

		public bool AddString(string se, string rep)
		{
			bool result;
			if (rep == null)
			{
				if (this.ConvertStringToByte(se, false))
				{
					this.replaceImm = false;
					result = true;
					return result;
				}
			}
			else if (this.ConvertStringToByte(se, false) && this.ConvertStringToByte(rep, true))
			{
				this.replaceImm = true;
				result = true;
				return result;
			}
			result = false;
			return result;
		}

		public bool ConvertStringToByte(string st, bool rep)
		{
			string text = st.Replace(Strings.Space(1), string.Empty).ToUpper();
			checked
			{
				bool result;
				if (text.Length % 2 != 0)
				{
					this.state = "String of byte must be power of two.";
					result = false;
				}
				else
				{
					int arg_3F_0 = 0;
					int num = text.Length - 1;
					for (int i = arg_3F_0; i <= num; i += 2)
					{
						string text2 = text.Substring(i, 2);
						byte[] item = new byte[0];
						if (Operators.CompareString(text2, "??", false) != 0)
						{
							try
							{
								item = new byte[]
								{
									byte.Parse(text2, NumberStyles.HexNumber)
								};
							}
							catch (Exception expr_83)
							{
								ProjectData.SetProjectError(expr_83);
								Exception ex = expr_83;
								this.state = ex.Message;
								result = false;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						else
						{
							item = new byte[]
							{
								0,
								0
							};
						}
						if (rep)
						{
							this.replace.Add(item);
						}
						else
						{
							this.search.Add(item);
						}
					}
					result = true;
				}
				return result;
			}
		}

		public bool Validate()
		{
			bool result;
			if (this.brakAfter != -1 && this.MustFind() < 1)
			{
				this.state = "Replacements count must be more than 0! (BrakAfter - ReplaceAfter < 1)";
				result = false;
			}
			else if (this.replaceAfter < 0)
			{
				this.state = "ReplaceAfter cannot be a negative value!";
				result = false;
			}
			else if (this.search == null)
			{
				this.state = "Pattern.Search is not specified!";
				result = false;
			}
			else if (this.replaceImm && this.replace == null)
			{
				this.state = "Pattern.Replace is not specified!";
				result = false;
			}
			else
			{
				bool flag = false;
				try
				{
					List<byte[]>.Enumerator enumerator = this.search.GetEnumerator();
					while (enumerator.MoveNext())
					{
						byte[] current = enumerator.Current;
						if (current.Length == 1)
						{
							flag = true;
							break;
						}
					}
                                        ((IDisposable)enumerator).Dispose();
                }
				finally
				{
					//List<byte[]>.Enumerator enumerator;

				}
				if (!flag)
				{
					this.state = "Pattern is not valid (Search bytes is not valid)!";
					result = false;
				}
				else
				{
					if (this.replaceImm)
					{
						flag = false;
						try
						{
							List<byte[]>.Enumerator enumerator2 = this.replace.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								byte[] current2 = enumerator2.Current;
								if (current2.Length == 1)
								{
									flag = true;
									break;
								}
							}
                            ((IDisposable)enumerator2).Dispose();
                        }
						finally
						{
							//List<byte[]>.Enumerator enumerator2;
							
						}
						if (!flag)
						{
							this.state = "Pattern is not valid (Replace bytes is not valid)!";
							result = false;
							return result;
						}
					}
					this.valid = flag;
					result = true;
				}
			}
			return result;
		}
	}

	public class FileWorkshop
	{
		public byte[] buffer;

		private string fullPathToFile;

		private FileStream fs;

		private int bufferSize;

		private long fsbufferc;

		private long currentBufOfs;

		private int reLength;

		private bool loaded;

		private MessageHeader state;

		public MessageHeader.Message CurState
		{
			get
			{
				return this.state.LastMessage();
			}
		}

		public MessageHeader.Message AllMessagesMessage
		{
			get
			{
				return this.state.AllMessagesMessage();
			}
		}

		public int BufferLength
		{
			get
			{
				return this.reLength;
			}
		}

		public long CurrentBufferOffset
		{
			get
			{
				return this.currentBufOfs;
			}
		}

		public bool EndOfFile
		{
			get
			{
				return this.currentBufOfs == this.fsbufferc;
			}
		}

		public FileWorkshop()
		{
			this.fullPathToFile = string.Empty;
			this.bufferSize = 2048;
			this.currentBufOfs = -1L;
			this.state = new MessageHeader();
		}

		public bool SetPosition(long bps)
		{
			bool result;
			if (bps > this.fsbufferc || bps < -1L)
			{
				this.state.AddMessage("SetBufferPosition: Index out of range exception.", 16);
				result = false;
			}
			else
			{
				this.currentBufOfs = bps;
				result = true;
			}
			return result;
		}

		public bool Close()
		{
			bool result;
			if (this.fs == null)
			{
				result = true;
			}
			else
			{
				this.fs.Close();
				this.fs = null;
				result = true;
			}
			return result;
		}

		public bool Load(string fp, int buf)
		{
			this.state.Clear();
			checked
			{
				bool result;
				if (buf < 16)
				{
					this.state.AddMessage("BufferSize Must be > 15.", 16);
					result = false;
				}
				else
				{
					this.fullPathToFile = fp;
					if (!this.CreateStream())
					{
						result = false;
					}
					else
					{
						this.bufferSize = buf;
						this.fsbufferc = (long)Math.Round(Math.Floor((double)this.fs.Length / (double)this.bufferSize));
						this.buffer = new byte[this.bufferSize - 1 + 1];
						this.currentBufOfs = -1L;
						this.loaded = true;
						result = true;
					}
				}
				return result;
			}
		}

		private bool CreateStream()
		{
			FileAttributes fileAttributes;
			bool result;
			try
			{
				fileAttributes = File.GetAttributes(this.fullPathToFile);
			}
			catch (Exception expr_0E)
			{
				ProjectData.SetProjectError(expr_0E);
				Exception ex = expr_0E;
				this.state.AddMessage(ex.Message, 16);
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			fileAttributes = FileAttributes.Normal;
			try
			{
				File.SetAttributes(this.fullPathToFile, fileAttributes);
			}
			catch (Exception expr_50)
			{
				ProjectData.SetProjectError(expr_50);
				Exception ex2 = expr_50;
				this.state.AddMessage(ex2.Message, 16);
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			try
			{
				this.fs = new FileStream(this.fullPathToFile, FileMode.Open, FileAccess.ReadWrite);
			}
			catch (Exception expr_93)
			{
				ProjectData.SetProjectError(expr_93);
				Exception ex3 = expr_93;
				if (this.fs != null)
				{
					this.fs.Dispose();
				}
				this.state.AddMessage(ex3.Message, 16);
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			if (this.fs.Length < 16L)
			{
				this.fs.Close();
				this.state.AddMessage("File is too short! (posible damaged)", 16);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		public bool ReadNext(bool forw = true)
		{
			checked
			{
				bool result;
				if (forw)
				{
					if (this.currentBufOfs + 1L > this.fsbufferc)
					{
						result = false;
						return result;
					}
					this.currentBufOfs += 1L;
				}
				else
				{
					if (this.currentBufOfs - 1L < 0L)
					{
						result = false;
						return result;
					}
					this.currentBufOfs -= 1L;
				}
				result = this.Read();
				return result;
			}
		}

		public bool ReadWhere(long at)
		{
			bool result;
			if (at > this.fsbufferc || at < 0L)
			{
				this.state.AddMessage("BufferPosition: Index out of range exception.", 16);
				result = false;
			}
			else
			{
				this.currentBufOfs = at;
				result = this.Read();
			}
			return result;
		}

		public bool Read()
		{
			if (this.fs == null)
			{
				this.state.AddMessage("FileStream not specifed, use load function first!", 16);
			}
			checked
			{
				if (this.EndOfFile)
				{
					this.reLength = (int)(this.fs.Length - unchecked((long)this.bufferSize) * this.currentBufOfs - 1L);
				}
				else
				{
					this.reLength = this.bufferSize - 1;
				}
				bool result;
				try
				{
					this.fs.Position = unchecked((long)this.bufferSize) * this.currentBufOfs;
					this.fs.Read(this.buffer, 0, this.buffer.Length);
				}
				catch (Exception expr_8D)
				{
					ProjectData.SetProjectError(expr_8D);
					Exception ex = expr_8D;
					if (this.fs != null)
					{
						this.fs.Dispose();
					}
					this.state.AddMessage(ex.Message, 16);
					result = false;
					ProjectData.ClearProjectError();
					return result;
				}
				result = true;
				return result;
			}
		}

		public bool FlushBuffer()
		{
			if (this.fs == null)
			{
				this.state.AddMessage("FileStream not specifed, use load function first!", 16);
			}
			checked
			{
				bool result;
				try
				{
					this.fs.Position = unchecked((long)this.bufferSize) * this.currentBufOfs;
					this.fs.Write(this.buffer, 0, this.reLength + 1);
				}
				catch (Exception expr_50)
				{
					ProjectData.SetProjectError(expr_50);
					Exception ex = expr_50;
					if (this.fs != null)
					{
						this.fs.Dispose();
					}
					this.state.AddMessage(ex.Message, 16);
					result = false;
					ProjectData.ClearProjectError();
					return result;
				}
				result = true;
				return result;
			}
		}

		public bool RunAway()
		{
			this.currentBufOfs = this.fsbufferc;
			return true;
		}
	}

	public string fullPathToFile;

	public bool msg;

	public List<Patcher.Pattern> patterns;

	public int bufferSize;

	private Patcher.FileWorkshop fileW;

	public string[] succesMessages;

	private MessageHeader state;

	public MessageHeader.Message CurState
	{
		get
		{
			return this.state.LastMessage();
		}
	}

	public MessageHeader.Message AllMessagesMessage
	{
		get
		{
			return this.state.AllMessagesMessage();
		}
	}

	public Patcher()
	{
		this.fullPathToFile = string.Empty;
		this.msg = false;
		this.patterns = new List<Patcher.Pattern>();
		this.bufferSize = 16;
		this.fileW = new Patcher.FileWorkshop();
		this.succesMessages = new string[]
		{
			"Pattern not found!!",
			"Patched!!",
			"Patched but result is other!!",
			"Found!!",
			"Found but result is other!!"
		};
		this.state = new MessageHeader();
	}

	public bool AddString(string se, string rep)
	{
		this.state.Clear();
		Patcher.Pattern pattern = new Patcher.Pattern();
		bool result;
		if (!pattern.AddString(se, rep))
		{
			this.state.AddMessage(pattern.CurState, 16);
			result = false;
		}
		else
		{
			this.patterns.Add(pattern);
			result = true;
		}
		return result;
	}

	public bool Patch()
	{
		this.state.Clear();
		bool result;
		if (this.patterns.Count == 0)
		{
			this.state.AddMessage("You did not specify the patterns! (patterns.Count = 0)", 16);
			result = false;
		}
		else if (!this.fileW.Load(this.fullPathToFile, this.bufferSize))
		{
			this.state.AddMessage(this.fileW.CurState);
			result = false;
		}
		else
		{
			try
			{
				List<Patcher.Pattern>.Enumerator enumerator = this.patterns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Patcher.Pattern current = enumerator.Current;
					this.fileW.SetPosition(-1L);
					if (this.FindAllPatterns(current) && current.ReplaceImmediately)
					{
						this.ReplaceAllPatterns(current);
					}
				}
                ((IDisposable)enumerator).Dispose();
            }
			finally
			{
				//List<Patcher.Pattern>.Enumerator enumerator;
				
			}
			this.fileW.Close();
			result = (this.state.MessageCount <= 0 && this.ResultInMessage());
		}
		return result;
	}

	private bool FindAllPatterns(Patcher.Pattern pt)
	{
		checked
		{
			bool result;
			if (!pt.ValidPattern && !pt.Validate())
			{
				this.state.AddMessage(pt.CurState, 0);
				result = false;
			}
			else
			{
				long num = 0L;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				while (this.fileW.ReadNext(true))
				{
					int arg_4A_0 = 0;
					int bufferLength = this.fileW.BufferLength;
					for (int i = arg_4A_0; i <= bufferLength; i++)
					{
						if (pt.search[num3].Length == 2 || this.fileW.buffer[i] == pt.search[num3][0])
						{
							if (num3 == 0)
							{
								num2 = i;
								num = this.fileW.CurrentBufferOffset;
							}
							if (pt.search.Count - 1 == num3)
							{
								num3 = 0;
								if (num4 == pt.replaceAfter)
								{
									num5++;
									pt.AddPlace(num, num2);
									if (pt.brakAfter != -1 && num5 == pt.brakAfter)
									{
										result = true;
										return result;
									}
								}
								else
								{
									num4++;
								}
							}
							else
							{
								num3++;
							}
						}
						else if (num3 > 0)
						{
							if (!this.fileW.EndOfFile || pt.search.Count - num3 <= this.fileW.BufferLength)
							{
								num3 = 0;
								if (this.fileW.CurrentBufferOffset != num && !this.fileW.ReadWhere(num))
								{
									if (this.fileW.CurState != null)
									{
										this.state.AddMessage(this.fileW.CurState);
									}
									result = false;
									return result;
								}
								i = num2;
							}
						}
					}
					Application.DoEvents();
				}
				if (this.fileW.CurState != null)
				{
					this.state.AddMessage(this.fileW.CurState);
					result = false;
				}
				else
				{
					if (pt.brakAfter == -1)
					{
						if (num5 > 0)
						{
							result = true;
							return result;
						}
					}
					else if (num5 > 0)
					{
						result = true;
						return result;
					}
					result = false;
				}
			}
			return result;
		}
	}

	private bool ReplaceAllPatterns(Patcher.Pattern pt)
	{
		checked
		{
			bool result;
			if (!pt.ValidPattern)
			{
				this.state.AddMessage(pt.CurState, 0);
				result = false;
			}
			else
			{
				int num = 0;
				List<Patcher.Pattern.Place> allPlaces = pt.AllPlaces;
				try
				{
					List<Patcher.Pattern.Place>.Enumerator enumerator = allPlaces.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Patcher.Pattern.Place current = enumerator.Current;
						int num2 = 0;
						bool flag = false;
						bool flag2 = false;
						if (!this.fileW.SetPosition(current.bufferPos - 1L))
						{
							this.state.AddMessage(this.fileW.CurState);
							result = false;
							return result;
						}
						while (this.fileW.ReadNext(true))
						{
							int arg_91_0 = 0;
							int bufferLength = this.fileW.BufferLength;
							for (int i = arg_91_0; i <= bufferLength; i++)
							{
								if (num2 == 0)
								{
									i = current.position;
								}
								if (pt.replace[num2].Length == 1)
								{
									this.fileW.buffer[i] = pt.replace[num2][0];
									flag = true;
								}
								num2++;
								if (flag && (pt.replace.Count == num2 || i == this.fileW.BufferLength))
								{
									this.fileW.FlushBuffer();
									flag2 = true;
									flag = false;
								}
								if (pt.replace.Count == num2)
								{
									if (flag2)
									{
										num++;
									}
									this.fileW.RunAway();
									break;
								}
							}
							Application.DoEvents();
						}
						if (this.fileW.CurState != null)
						{
							this.state.AddMessage(this.fileW.CurState);
							result = false;
							return result;
						}
					}
                    ((IDisposable)enumerator).Dispose();
                }
				finally
				{
					//List<Patcher.Pattern.Place>.Enumerator enumerator;
					
				}
				result = true;
			}
			return result;
		}
	}

	private bool ResultInMessage()
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		checked
		{
			try
			{
				List<Patcher.Pattern>.Enumerator enumerator = this.patterns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Patcher.Pattern current = enumerator.Current;
					if (current.SuccesFind)
					{
						num2++;
					}
					else if (current.FindCount > 0)
					{
						num2++;
						num++;
					}
					else
					{
						num++;
					}
					if (current.ReplaceImmediately)
					{
						flag = true;
					}
				}
                ((IDisposable)enumerator).Dispose();
            }
			finally
			{
				//List<Patcher.Pattern>.Enumerator enumerator;
				
			}
			bool result;
			if (this.msg)
			{
				if (flag)
				{
					if (num > 0 && num2 > 0)
					{
						this.state.AddMessage(this.succesMessages[2], 0);
						result = true;
						return result;
					}
					if (num == 0 && num2 > 0)
					{
						this.state.AddMessage(this.succesMessages[1], 0);
						result = true;
						return result;
					}
					this.state.AddMessage(this.succesMessages[0], 0);
				}
				else
				{
					if (num > 0 && num2 > 0)
					{
						this.state.AddMessage(this.succesMessages[4], 0);
						result = true;
						return result;
					}
					if (num == 0 && num2 > 0)
					{
						this.state.AddMessage(this.succesMessages[3], 0);
						result = true;
						return result;
					}
					this.state.AddMessage(this.succesMessages[0], 0);
				}
			}
			else if (flag)
			{
				if (num > 0 && num2 > 0)
				{
					result = true;
					return result;
				}
				if (num == 0 && num2 > 0)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (num > 0 && num2 > 0)
				{
					result = true;
					return result;
				}
				if (num == 0 && num2 > 0)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
	}
}
