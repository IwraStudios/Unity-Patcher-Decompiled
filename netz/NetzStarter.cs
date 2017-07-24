using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace netz
{
	public class NetzStarter
	{
		private static readonly string Name = "Name";

		private static readonly string Culture = "Culture";

		private static readonly string NetzSuffix = "z.dll";

		private static HybridDictionary cache = null;

		private static ResourceManager rm = null;

		private static ArrayList xrRm = null;

		private static bool inResourceResolveFlag = false;

		[STAThread]
		public static int Main(string[] args)
		{
			int result;
			try
			{
				NetzStarter.InitXR();
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += new ResolveEventHandler(NetzStarter.NetzResolveEventHandler);
				result = NetzStarter.StartApp(args);
                MessageBox.Show(Convert.ToString(result));
			}
			catch (Exception ex)
			{
				string text = " .NET Runtime: ";
				NetzStarter.Log(string.Concat(new object[]
				{
					"#Error: ",
					ex.GetType().ToString(),
					Environment.NewLine,
					ex.Message,
					Environment.NewLine,
					ex.StackTrace,
					Environment.NewLine,
					ex.InnerException,
					Environment.NewLine,
					"Using",
					text,
					Environment.Version.ToString(),
					Environment.NewLine,
					"Created with",
					text,
					"4.0.30319.34014"
				}));
				result = -1;
			}
			return result;
		}

		private static void InitXR()
		{
			try
			{
				string text = "file:\\";
				string text2 = "-netz.resources";
				string text3 = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
				if (text3.StartsWith(text))
				{
					text3 = text3.Substring(text.Length, text3.Length - text.Length);
				}
				string[] files = Directory.GetFiles(text3, "*" + text2);
				if (files != null && files.Length > 0)
				{
					NetzStarter.xrRm = new ArrayList();
					for (int i = 0; i < files.Length; i++)
					{
						string text4 = Path.GetFileName(files[i]);
						text4 = text4.Substring(0, text4.Length - text2.Length);
						ResourceManager resourceManager = ResourceManager.CreateFileBasedResourceManager(text4 + "-netz", text3, null);
						if (resourceManager != null)
						{
							NetzStarter.xrRm.Add(resourceManager);
						}
					}
				}
			}
			catch
			{
			}
		}

		public static int StartApp(string[] args)
		{
			byte[] resource = NetzStarter.GetResource("A6C24BF5-3690-4982-887E-11E1B159B249");
			if (resource == null)
			{
				throw new Exception("application data cannot be found");
			}
			Assembly assembly = NetzStarter.GetAssembly(resource);
			return NetzStarter.InvokeApp(assembly, args);
		}

		private static Assembly GetAssembly(byte[] data)
		{
			MemoryStream memoryStream = null;
			Assembly result = null;
			try
			{
				memoryStream = NetzStarter.UnZip(data);
				memoryStream.Seek(0L, SeekOrigin.Begin);
                using (FileStream file = new FileStream("file.dll", FileMode.Create, System.IO.FileAccess.Write))
                {
                    byte[] bytes = new byte[memoryStream.Length];
                    memoryStream.Read(bytes, 0, (int)memoryStream.Length);
                    file.Write(bytes, 0, bytes.Length);
                    memoryStream.Close();
                }
                result = Assembly.Load(memoryStream.ToArray());
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
				memoryStream = null;
			}
			return result;
		}

#if false
        private static Assembly LoadZipDll()
        {
            Assembly result = null;
            MemoryStream memoryStream = null;
            try
            {
                byte[] resource = NetzStarter.GetResource("zip.dll");
                if (resource == null)
                {
                    return null;
                }
                memoryStream = new MemoryStream(resource);
                result = Assembly.Load(memoryStream.ToArray());
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (memoryStream != null)
                {
                    memoryStream.Close();
                }
                memoryStream = null;
            }
            return result;
        } 
#endif

        private static int InvokeApp(Assembly assembly, string[] args)
		{
			MethodInfo entryPoint = assembly.EntryPoint;
			ParameterInfo[] parameters = entryPoint.GetParameters();
			object[] parameters2 = null;
			if (parameters != null && parameters.Length > 0)
			{
				parameters2 = new object[]
				{
					args
				};
			}
			object obj = entryPoint.Invoke(null, parameters2);
			if (obj == null)
			{
				return 0;
			}
			if (obj is int)
			{
				return (int)obj;
			}
			return 0;
		}

		private static Assembly NetzResolveEventHandler(object sender, ResolveEventArgs args)
		{
			if (NetzStarter.inResourceResolveFlag)
			{
				return null;
			}
			return NetzStarter.GetAssemblyByName(args.Name);
		}

		private static byte[] GetResource(string id)
		{
			byte[] array = null;
			if (NetzStarter.rm == null)
			{
				NetzStarter.rm = new ResourceManager("app", Assembly.GetExecutingAssembly());
			}
			try
			{
				NetzStarter.inResourceResolveFlag = true;
				string name = NetzStarter.MangleDllName(id);
				if (array == null && NetzStarter.xrRm != null)
				{
					for (int i = 0; i < NetzStarter.xrRm.Count; i++)
					{
						try
						{
							ResourceManager resourceManager = (ResourceManager)NetzStarter.xrRm[i];
							if (resourceManager != null)
							{
								array = (byte[])resourceManager.GetObject(name);
							}
						}
						catch
						{
						}
						if (array != null)
						{
							break;
						}
					}
				}
				if (array == null)
				{
					array = (byte[])NetzStarter.rm.GetObject(name);
				}
			}
			finally
			{
				NetzStarter.inResourceResolveFlag = false;
			}
			return array;
		}

		private static string MangleDllName(string dll)
		{
			string text = dll.Replace(" ", "!1");
			text = text.Replace(",", "!2");
			text = text.Replace(".Resources", "!3");
			text = text.Replace(".resources", "!3");
			return text.Replace("Culture", "!4");
		}

		private static MemoryStream UnZip(byte[] data)
		{
			if (data == null)
			{
				return null;
			}
			MemoryStream memoryStream = null;
			MemoryStream memoryStream2 = null;
			InflaterInputStream inflaterInputStream = null;
			try
			{
				memoryStream = new MemoryStream(data);
				memoryStream2 = new MemoryStream();
				inflaterInputStream = new InflaterInputStream(memoryStream);
				byte[] array = new byte[data.Length];
				while (true)
				{
					int num = inflaterInputStream.Read(array, 0, array.Length);
					if (num <= 0)
					{
						break;
					}
					memoryStream2.Write(array, 0, num);
				}
				memoryStream2.Flush();
				memoryStream2.Seek(0L, SeekOrigin.Begin);
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
				if (inflaterInputStream != null)
				{
					inflaterInputStream.Close();
				}
				memoryStream = null;
				inflaterInputStream = null;
			}
			return memoryStream2;
		}

		private static byte[] ResolveDLL(StringDictionary assName)
		{
			string text = assName[NetzStarter.Culture];
			string text2 = assName[NetzStarter.Name];
			bool flag = text == null || text.ToLower().Equals("neutral");
			AppDomain currentDomain = AppDomain.CurrentDomain;
			StringCollection stringCollection = new StringCollection();
			string text3 = currentDomain.SetupInformation.ApplicationBase;
			if (!flag)
			{
				text3 = Path.Combine(text3, text);
			}
			stringCollection.Add(text3);
			stringCollection.Add(Path.Combine(text3, text2));
			byte[] array = NetzStarter.ProbeDirs(stringCollection, text2);
			if (array != null)
			{
				return array;
			}
			stringCollection = new StringCollection();
			text3 = currentDomain.SetupInformation.PrivateBinPath;
			if (text3 == null || text3.Trim().Length <= 0)
			{
				return null;
			}
			string[] array2 = text3.Split(new char[]
			{
				Path.PathSeparator
			});
			for (int i = 0; i < array2.Length; i++)
			{
				text3 = array2[i].Trim(new char[]
				{
					' ',
					'\t',
					Path.PathSeparator
				});
				if (!Path.IsPathRooted(text3))
				{
					text3 = Path.Combine(currentDomain.SetupInformation.ApplicationBase, text3);
				}
				if (!flag)
				{
					text3 = Path.Combine(text3, text);
				}
				stringCollection.Add(text3);
				stringCollection.Add(Path.Combine(text3, text2));
			}
			return NetzStarter.ProbeDirs(stringCollection, text2);
		}

		private static byte[] ProbeDirs(StringCollection probePaths, string assName)
		{
			for (int i = 0; i < probePaths.Count; i++)
			{
				string text = Path.Combine(probePaths[i], assName + NetzStarter.NetzSuffix);
				if (File.Exists(text))
				{
					return NetzStarter.ReadFile(text);
				}
			}
			return null;
		}

		private static byte[] ReadFile(string file)
		{
			FileStream fileStream = null;
			byte[] array = null;
			try
			{
				fileStream = File.OpenRead(file);
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Flush();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
				fileStream = null;
			}
			return array;
		}

		private static void Log(string s)
		{
			MessageBox.Show(null, s, "Error");
		}

		private static Assembly GetAssemblyByName(string name)
		{
			if (name == null)
			{
				return null;
			}
			if (NetzStarter.cache == null)
			{
				NetzStarter.cache = new HybridDictionary();
			}
			name = name.Trim();
			string key = name.ToLower();
			if (NetzStarter.cache[key] != null)
			{
				return (Assembly)NetzStarter.cache[key];
			}
			StringDictionary stringDictionary = NetzStarter.ParseAssName(name);
			string text = stringDictionary[NetzStarter.Name];
			if (text == null)
			{
				return null;
			}
			byte[] array = null;
			/*if (text.ToLower().Equals("zip"))
			{
				Assembly assembly = NetzStarter.LoadZipDll();
				NetzStarter.cache[key] = assembly;
				return assembly;
			}*/
			array = NetzStarter.GetResource(name);
			if (array == null)
			{
				array = NetzStarter.GetResource(name.ToLower());
			}
			if (array == null)
			{
				array = NetzStarter.GetResource(text);
			}
			if (array == null)
			{
				array = NetzStarter.GetResource(text.ToLower());
			}
			if (array == null)
			{
				array = NetzStarter.GetResource(Path.GetFileNameWithoutExtension(text).ToLower());
			}
			if (array == null)
			{
				try
				{
					array = NetzStarter.ResolveDLL(stringDictionary);
				}
				catch
				{
					array = null;
				}
			}
			if (array == null)
			{
				return null;
			}
			Assembly assembly2 = NetzStarter.GetAssembly(array);
			array = null;
			NetzStarter.cache[key] = assembly2;
			return assembly2;
		}

		private static StringDictionary ParseAssName(string fullAssName)
		{
			StringDictionary stringDictionary = new StringDictionary();
			string[] array = fullAssName.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Trim(new char[]
				{
					' ',
					','
				}).Split(new char[]
				{
					'='
				});
				if (array2.Length < 2)
				{
					stringDictionary.Add(NetzStarter.Name, array2[0]);
				}
				else
				{
					stringDictionary.Add(array2[0].Trim(new char[]
					{
						' ',
						'='
					}), array2[1].Trim(new char[]
					{
						' ',
						'='
					}));
				}
			}
			return stringDictionary;
		}
	}
}
