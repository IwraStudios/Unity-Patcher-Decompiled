using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;
using My.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[AccessedThroughProperty("TextBox11")]
	private TextBox _TextBox11;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	internal virtual Button Button1
	{
		get
		{
			return this._Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button1_Click);
			if (this._Button1 != null)
			{
				this._Button1.Click -= value2;
			}
			this._Button1 = value;
			if (this._Button1 != null)
			{
				this._Button1.Click += value2;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return this._Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return this._TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			MouseEventHandler value2 = new MouseEventHandler(this.TextBox2_MouseClick);
			if (this._TextBox2 != null)
			{
				this._TextBox2.MouseClick -= value2;
			}
			this._TextBox2 = value;
			if (this._TextBox2 != null)
			{
				this._TextBox2.MouseClick += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return this._Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button2_Click);
			if (this._Button2 != null)
			{
				this._Button2.Click -= value2;
			}
			this._Button2 = value;
			if (this._Button2 != null)
			{
				this._Button2.Click += value2;
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return this._TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TextBox1 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return this._Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label3 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		get
		{
			return this._TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TextBox3 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return this._Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label2 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		get
		{
			return this._TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			MouseEventHandler value2 = new MouseEventHandler(this.TextBox4_MouseClick);
			EventHandler value3 = new EventHandler(this.TextBox4_TextChanged);
			if (this._TextBox4 != null)
			{
				this._TextBox4.MouseClick -= value2;
				this._TextBox4.TextChanged -= value3;
			}
			this._TextBox4 = value;
			if (this._TextBox4 != null)
			{
				this._TextBox4.MouseClick += value2;
				this._TextBox4.TextChanged += value3;
			}
		}
	}

	internal virtual TextBox TextBox5
	{
		get
		{
			return this._TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			MouseEventHandler value2 = new MouseEventHandler(this.TextBox5_MouseClick);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.TextBox5_KeyPress);
			EventHandler value4 = new EventHandler(this.TextBox5_TextChanged);
			if (this._TextBox5 != null)
			{
				this._TextBox5.MouseClick -= value2;
				this._TextBox5.KeyPress -= value3;
				this._TextBox5.TextChanged -= value4;
			}
			this._TextBox5 = value;
			if (this._TextBox5 != null)
			{
				this._TextBox5.MouseClick += value2;
				this._TextBox5.KeyPress += value3;
				this._TextBox5.TextChanged += value4;
			}
		}
	}

	internal virtual TextBox TextBox6
	{
		get
		{
			return this._TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			MouseEventHandler value2 = new MouseEventHandler(this.TextBox6_MouseClick);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.TextBox6_KeyPress);
			EventHandler value4 = new EventHandler(this.TextBox6_TextChanged);
			if (this._TextBox6 != null)
			{
				this._TextBox6.MouseClick -= value2;
				this._TextBox6.KeyPress -= value3;
				this._TextBox6.TextChanged -= value4;
			}
			this._TextBox6 = value;
			if (this._TextBox6 != null)
			{
				this._TextBox6.MouseClick += value2;
				this._TextBox6.KeyPress += value3;
				this._TextBox6.TextChanged += value4;
			}
		}
	}

	internal virtual TextBox TextBox8
	{
		get
		{
			return this._TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.TextBox8_KeyPress);
			EventHandler value3 = new EventHandler(this.TextBox8_TextChanged);
			MouseEventHandler value4 = new MouseEventHandler(this.TextBox8_MouseClick);
			if (this._TextBox8 != null)
			{
				this._TextBox8.KeyPress -= value2;
				this._TextBox8.TextChanged -= value3;
				this._TextBox8.MouseClick -= value4;
			}
			this._TextBox8 = value;
			if (this._TextBox8 != null)
			{
				this._TextBox8.KeyPress += value2;
				this._TextBox8.TextChanged += value3;
				this._TextBox8.MouseClick += value4;
			}
		}
	}

	internal virtual TextBox TextBox9
	{
		get
		{
			return this._TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.TextBox9_KeyPress);
			EventHandler value3 = new EventHandler(this.TextBox9_TextChanged);
			MouseEventHandler value4 = new MouseEventHandler(this.TextBox9_MouseClick);
			if (this._TextBox9 != null)
			{
				this._TextBox9.KeyPress -= value2;
				this._TextBox9.TextChanged -= value3;
				this._TextBox9.MouseClick -= value4;
			}
			this._TextBox9 = value;
			if (this._TextBox9 != null)
			{
				this._TextBox9.KeyPress += value2;
				this._TextBox9.TextChanged += value3;
				this._TextBox9.MouseClick += value4;
			}
		}
	}

	internal virtual TextBox TextBox11
	{
		get
		{
			return this._TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.TextBox11_KeyPress);
			MouseEventHandler value3 = new MouseEventHandler(this.TextBox11_MouseClick);
			if (this._TextBox11 != null)
			{
				this._TextBox11.KeyPress -= value2;
				this._TextBox11.MouseClick -= value3;
			}
			this._TextBox11 = value;
			if (this._TextBox11 != null)
			{
				this._TextBox11.KeyPress += value2;
				this._TextBox11.MouseClick += value3;
			}
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return this._Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button3_Click);
			if (this._Button3 != null)
			{
				this._Button3.Click -= value2;
			}
			this._Button3 = value;
			if (this._Button3 != null)
			{
				this._Button3.Click += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		get
		{
			return this._ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._ComboBox1 = value;
		}
	}

	internal virtual Button Button4
	{
		get
		{
			return this._Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button4_Click);
			if (this._Button4 != null)
			{
				this._Button4.Click -= value2;
			}
			this._Button4 = value;
			if (this._Button4 != null)
			{
				this._Button4.Click += value2;
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return this._ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._ProgressBar1 = value;
		}
	}

	internal virtual Button Button5
	{
		get
		{
			return this._Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button5_Click);
			if (this._Button5 != null)
			{
				this._Button5.Click -= value2;
			}
			this._Button5 = value;
			if (this._Button5 != null)
			{
				this._Button5.Click += value2;
			}
		}
	}

	internal virtual ToolTip ToolTip1
	{
		get
		{
			return this._ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._ToolTip1 = value;
		}
	}

	public Form1()
	{
		base.Load += new EventHandler(this.Form1_Load);
		this.InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		this.Button1 = new Button();
		this.Label1 = new Label();
		this.TextBox2 = new TextBox();
		this.Button2 = new Button();
		this.TextBox1 = new TextBox();
		this.Label3 = new Label();
		this.TextBox3 = new TextBox();
		this.Label2 = new Label();
		this.TextBox4 = new TextBox();
		this.TextBox5 = new TextBox();
		this.TextBox6 = new TextBox();
		this.TextBox8 = new TextBox();
		this.TextBox9 = new TextBox();
		this.TextBox11 = new TextBox();
		this.Button3 = new Button();
		this.ComboBox1 = new ComboBox();
		this.Button4 = new Button();
		this.ProgressBar1 = new ProgressBar();
		this.Button5 = new Button();
		this.ToolTip1 = new ToolTip(this.components);
		this.SuspendLayout();
		this.Button1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Button1.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		Control arg_146_0 = this.Button1;
		Point location = new Point(224, 48);
		arg_146_0.Location = location;
		this.Button1.Name = "Button1";
		Control arg_16E_0 = this.Button1;
		Size size = new Size(92, 34);
		arg_16E_0.Size = size;
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Patch";
		this.ToolTip1.SetToolTip(this.Button1, "Patch the Application in specified folder.");
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.Label1.ForeColor = Color.Black;
		Control arg_200_0 = this.Label1;
		location = new Point(9, 9);
		arg_200_0.Location = location;
		this.Label1.Name = "Label1";
		Control arg_228_0 = this.Label1;
		size = new Size(91, 18);
		arg_228_0.Size = size;
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Unity Folder";
		this.TextBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		Control arg_268_0 = this.TextBox2;
		location = new Point(12, 30);
		arg_268_0.Location = location;
		this.TextBox2.Name = "TextBox2";
		Control arg_293_0 = this.TextBox2;
		size = new Size(206, 20);
		arg_293_0.Size = size;
		this.TextBox2.TabIndex = 4;
		this.Button2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Button2.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		Control arg_2E7_0 = this.Button2;
		location = new Point(224, 9);
		arg_2E7_0.Location = location;
		this.Button2.Name = "Button2";
		Control arg_30F_0 = this.Button2;
		size = new Size(92, 34);
		arg_30F_0.Size = size;
		this.Button2.TabIndex = 11;
		this.Button2.Text = "Browse";
		this.Button2.UseVisualStyleBackColor = true;
		this.TextBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.TextBox1.Font = new Font("Lucida Console", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		Control arg_380_0 = this.TextBox1;
		location = new Point(12, 181);
		arg_380_0.Location = location;
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.ScrollBars = ScrollBars.Vertical;
		Control arg_3CF_0 = this.TextBox1;
		size = new Size(304, 114);
		arg_3CF_0.Size = size;
		this.TextBox1.TabIndex = 17;
		this.Label3.AutoSize = true;
		this.Label3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		Control arg_420_0 = this.Label3;
		location = new Point(9, 57);
		arg_420_0.Location = location;
		this.Label3.Name = "Label3";
		Control arg_448_0 = this.Label3;
		size = new Size(104, 18);
		arg_448_0.Size = size;
		this.Label3.TabIndex = 15;
		this.Label3.Text = "Release Date";
		Control arg_47C_0 = this.TextBox3;
		location = new Point(12, 78);
		arg_47C_0.Location = location;
		this.TextBox3.MaxLength = 15;
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.ReadOnly = true;
		Control arg_4C0_0 = this.TextBox3;
		size = new Size(206, 20);
		arg_4C0_0.Size = size;
		this.TextBox3.TabIndex = 16;
		this.Label2.AutoSize = true;
		this.Label2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.Label2.ForeColor = Color.Black;
		Control arg_521_0 = this.Label2;
		location = new Point(9, 107);
		arg_521_0.Location = location;
		this.Label2.Name = "Label2";
		Control arg_549_0 = this.Label2;
		size = new Size(105, 18);
		arg_549_0.Size = size;
		this.Label2.TabIndex = 17;
		this.Label2.Text = "Serial number";
		this.TextBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_58D_0 = this.TextBox4;
		location = new Point(12, 128);
		arg_58D_0.Location = location;
		this.TextBox4.MaxLength = 2;
		this.TextBox4.Name = "TextBox4";
		Control arg_5C1_0 = this.TextBox4;
		size = new Size(25, 20);
		arg_5C1_0.Size = size;
		this.TextBox4.TabIndex = 18;
		this.TextBox4.Text = "U3";
		this.TextBox5.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_605_0 = this.TextBox5;
		location = new Point(43, 128);
		arg_605_0.Location = location;
		this.TextBox5.MaxLength = 4;
		this.TextBox5.Name = "TextBox5";
		Control arg_639_0 = this.TextBox5;
		size = new Size(40, 20);
		arg_639_0.Size = size;
		this.TextBox5.TabIndex = 19;
		this.TextBox5.Text = "AAAA";
		this.TextBox6.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_67D_0 = this.TextBox6;
		location = new Point(89, 128);
		arg_67D_0.Location = location;
		this.TextBox6.MaxLength = 4;
		this.TextBox6.Name = "TextBox6";
		Control arg_6B1_0 = this.TextBox6;
		size = new Size(40, 20);
		arg_6B1_0.Size = size;
		this.TextBox6.TabIndex = 22;
		this.TextBox6.Text = "AAAA";
		this.TextBox8.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_6F8_0 = this.TextBox8;
		location = new Point(135, 128);
		arg_6F8_0.Location = location;
		this.TextBox8.MaxLength = 4;
		this.TextBox8.Name = "TextBox8";
		Control arg_72C_0 = this.TextBox8;
		size = new Size(40, 20);
		arg_72C_0.Size = size;
		this.TextBox8.TabIndex = 23;
		this.TextBox8.Text = "AAAA";
		this.TextBox9.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_773_0 = this.TextBox9;
		location = new Point(181, 128);
		arg_773_0.Location = location;
		this.TextBox9.MaxLength = 4;
		this.TextBox9.Name = "TextBox9";
		Control arg_7A7_0 = this.TextBox9;
		size = new Size(40, 20);
		arg_7A7_0.Size = size;
		this.TextBox9.TabIndex = 24;
		this.TextBox9.Text = "AAAA";
		this.TextBox11.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_7EE_0 = this.TextBox11;
		location = new Point(227, 128);
		arg_7EE_0.Location = location;
		this.TextBox11.MaxLength = 4;
		this.TextBox11.Name = "TextBox11";
		Control arg_822_0 = this.TextBox11;
		size = new Size(40, 20);
		arg_822_0.Size = size;
		this.TextBox11.TabIndex = 25;
		this.TextBox11.Text = "NUUN";
		this.Button3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Button3.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		Control arg_887_0 = this.Button3;
		location = new Point(224, 88);
		arg_887_0.Location = location;
		this.Button3.Name = "Button3";
		Control arg_8AF_0 = this.Button3;
		size = new Size(92, 34);
		arg_8AF_0.Size = size;
		this.Button3.TabIndex = 26;
		this.Button3.Text = "Cre Lic";
		this.ToolTip1.SetToolTip(this.Button3, "Create License file in specified folder.\r\nThe license will not work, if application not patched yet or\r\nsystem date and time are not correct.");
		this.Button3.UseVisualStyleBackColor = true;
		this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		this.ComboBox1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.ComboBox1.FormattingEnabled = true;
		Control arg_941_0 = this.ComboBox1;
		location = new Point(12, 152);
		arg_941_0.Location = location;
		this.ComboBox1.Name = "ComboBox1";
		Control arg_96C_0 = this.ComboBox1;
		size = new Size(304, 23);
		arg_96C_0.Size = size;
		this.ComboBox1.TabIndex = 27;
		this.Button4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		Control arg_9A0_0 = this.Button4;
		location = new Point(271, 126);
		arg_9A0_0.Location = location;
		this.Button4.Name = "Button4";
		Control arg_9C8_0 = this.Button4;
		size = new Size(45, 23);
		arg_9C8_0.Size = size;
		this.Button4.TabIndex = 28;
		this.Button4.Text = "Rand";
		this.Button4.UseVisualStyleBackColor = true;
		Control arg_A0B_0 = this.ProgressBar1;
		location = new Point(12, 152);
		arg_A0B_0.Location = location;
		this.ProgressBar1.Name = "ProgressBar1";
		Control arg_A36_0 = this.ProgressBar1;
		size = new Size(304, 23);
		arg_A36_0.Size = size;
		this.ProgressBar1.Style = ProgressBarStyle.Marquee;
		this.ProgressBar1.TabIndex = 29;
		this.ProgressBar1.Visible = false;
		this.Button5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_A96_0 = this.Button5;
		location = new Point(135, 104);
		arg_A96_0.Location = location;
		this.Button5.Name = "Button5";
		Control arg_ABE_0 = this.Button5;
		size = new Size(83, 21);
		arg_ABE_0.Size = size;
		this.Button5.TabIndex = 30;
		this.Button5.Text = "Edit";
		this.ToolTip1.SetToolTip(this.Button5, "Edit License file.");
		this.Button5.UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = SystemColors.Control;
		size = new Size(328, 307);
		this.ClientSize = size;
		this.Controls.Add(this.Button5);
		this.Controls.Add(this.ProgressBar1);
		this.Controls.Add(this.Button4);
		this.Controls.Add(this.ComboBox1);
		this.Controls.Add(this.Button3);
		this.Controls.Add(this.TextBox11);
		this.Controls.Add(this.TextBox9);
		this.Controls.Add(this.TextBox8);
		this.Controls.Add(this.TextBox6);
		this.Controls.Add(this.TextBox5);
		this.Controls.Add(this.TextBox4);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.TextBox3);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.TextBox1);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.TextBox2);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		this.MaximizeBox = false;
		this.Name = "Form1";
		this.Text = "Unity 4.x Pro Patch";
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		this.TextBox1.Text = Resources.notes;
		this.TextBox3.Text = "21.08.2014";
		this.ComboBox1.Items.Add("Unity 4.0.0f0 - 4.5.3f3");
		this.ComboBox1.Items.Add("Unity 5.0.0f1 (beta)");
		this.ComboBox1.SelectedIndex = 0;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (this.TextBox2.Text.Length <= 1)
		{
			this.TextBox2.Text = Application.StartupPath;
		}
		string text = this.TextBox2.Text;
		string str = "Unity.exe";
		try
		{
			Directory.SetCurrentDirectory(text);
		}
		catch (Exception expr_3D)
		{
			ProjectData.SetProjectError(expr_3D);
			Exception ex = expr_3D;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
			ProjectData.ClearProjectError();
			return;
		}
		if (!File.Exists(text + "/" + str))
		{
			Interaction.MsgBox("Application not found!\r\nYou need to specify the destination folder or copy the \"patch file\" in directory with application.", MsgBoxStyle.Critical, null);
		}
		else
		{
			Process[] processesByName = Process.GetProcessesByName("unity");
			if (processesByName.Length > 0)
			{
				Interaction.MsgBox("Need to close application first.", MsgBoxStyle.Critical, null);
			}
			else
			{
				string se = "CC 55 8B EC 83 EC ?? 53 56 8B F1 80 7E ?? ?? 57 75 ??";
				string rep = "CC B0 01 C3 83 EC ?? 53 56 8B F1 80 7E ?? ?? 57 75 ??";
				string se2 = "CC 40 57 48 83 EC 30 80 79 ?? ?? 48 8B F9 75 ??";
				string rep2 = "CC B0 01 C3 90 90 90 80 79 ?? ?? 48 8B F9 75 ??";
                Patcher patcher = new Patcher()
                {
                    fullPathToFile = text + "/" + str
                };
                this.DissableUi();
				patcher.msg = true;
				if (patcher.AddString(se, rep))
				{
					if (patcher.Patch())
					{
						this.EnableUi();
						if (patcher.msg && patcher.CurState != null)
						{
							Interaction.MsgBox(patcher.CurState.message, (MsgBoxStyle)patcher.CurState.errorLevel, null);
						}
						if (this.ComboBox1.SelectedIndex > 0)
						{
							this.Wrlc4x1(text, true, this.ComboBox1.SelectedIndex);
						}
						else
						{
							this.Wrlc4x1(text, true, this.ComboBox1.SelectedIndex);
						}
						return;
					}
					if (this.ComboBox1.SelectedIndex > 0)
					{
						patcher.patterns.Clear();
						if (patcher.AddString(se2, rep2) && patcher.Patch())
						{
							this.EnableUi();
							if (patcher.msg && patcher.CurState != null)
							{
								Interaction.MsgBox(patcher.CurState.message, (MsgBoxStyle)patcher.CurState.errorLevel, null);
							}
							if (this.ComboBox1.SelectedIndex > 0)
							{
								this.Wrlc4x1(text, true, this.ComboBox1.SelectedIndex);
							}
							else
							{
								this.Wrlc4x1(text, true, this.ComboBox1.SelectedIndex);
							}
							return;
						}
					}
				}
				this.EnableUi();
				if (patcher.CurState != null)
				{
					Interaction.MsgBox(patcher.CurState.message, (MsgBoxStyle)patcher.CurState.errorLevel, null);
				}
				else
				{
					Interaction.MsgBox("Inside error!!", MsgBoxStyle.OkOnly, null);
				}
			}
		}
	}

	private bool EnableUi()
	{
		this.ProgressBar1.Visible = false;
		this.ComboBox1.Visible = true;
		this.Button3.Enabled = true;
		this.Button1.Enabled = true;
		return true;
	}

	private bool DissableUi()
	{
		this.Button1.Enabled = false;
		this.Button3.Enabled = false;
		this.ComboBox1.Visible = false;
		this.ProgressBar1.Visible = true;
		this.ProgressBar1.Value = 0;
		return true;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		if (Directory.Exists(this.TextBox2.Text))
		{
			folderBrowserDialog.SelectedPath = this.TextBox2.Text;
		}
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			this.TextBox2.Text = folderBrowserDialog.SelectedPath;
		}
	}

	private bool TestAtr(string path)
	{
		FileAttributes fileAttributes;
		bool result;
		try
		{
			fileAttributes = File.GetAttributes(path);
		}
		catch (Exception expr_09)
		{
			ProjectData.SetProjectError(expr_09);
			Exception ex = expr_09;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		fileAttributes = FileAttributes.Normal;
		try
		{
			File.SetAttributes(path, fileAttributes);
		}
		catch (Exception expr_3D)
		{
			ProjectData.SetProjectError(expr_3D);
			Exception ex2 = expr_3D;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
			result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		result = true;
		return result;
	}

	private bool Wrlc4x1(string appDir, bool spfold, int version)
	{
		string text = string.Format("{0}-{1}-{2}-{3}-{4}", new object[]
		{
			this.TextBox4.Text,
			this.TextBox5.Text,
			this.TextBox6.Text,
			this.TextBox8.Text,
			this.TextBox9.Text
		});
		bool result;
		if (checked(text.Length + this.TextBox11.TextLength) != 26)
		{
			Interaction.MsgBox("Invalid Key must be \"22\" chars.", MsgBoxStyle.OkOnly, null);
			result = false;
		}
		else
		{
			List<byte> list = new List<byte>();
			list.AddRange(new byte[]
			{
				1,
				0,
				0,
				0
			});
			list.AddRange(Encoding.ASCII.GetBytes(string.Format("{0}-{1}", text, this.TextBox11.Text)));
            List<string> list2 = new List<string>
            {
                "<root>",
                "  <License id=\"Terms\">",
                "    <ClientProvidedVersion Value=\"\"/>",
                string.Format("    <DeveloperData Value=\"{0}\"/>", Convert.ToBase64String(list.ToArray())),
                "    <Features>"
            };
            List<int> list3 = LicHeader.ReadAll();
			try
			{
				List<int>.Enumerator enumerator = list3.GetEnumerator();
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					list2.Add("      <Feature Value=\"" + current.ToString() + "\"/>");
				}
                ((IDisposable)enumerator).Dispose();
            }
			finally
			{
				//List<int>.Enumerator enumerator;
				
			}
			list2.Add("    </Features>");
			if (version > 0)
			{
				list2.Add("    <LicenseVersion Value=\"5.x\"/>");
			}
			else
			{
				list2.Add("    <LicenseVersion Value=\"4.x\"/>");
			}
			list2.Add("    <MachineBindings>");
			list2.Add("    </MachineBindings>");
			list2.Add("    <MachineID Value=\"\"/>");
			list2.Add("    <SerialHash Value=\"\"/>");
			list2.Add(string.Format("    <SerialMasked Value=\"{0}-XXXX\"/>", text));
			DateTime now = DateTime.Now;
			list2.Add(string.Format("    <StartDate Value=\"{0}T00:00:00\"/>", now.AddDays(-1.0).ToString("yyyy-MM-dd")));
			list2.Add("    <StopDate Value=\"\"/>");
			list2.Add(string.Format("    <UpdateDate Value=\"{0}T00:00:00\"/>", now.AddYears(10).ToString("yyyy-MM-dd")));
			list2.Add("  </License>");
			list2.Add("");
			list2.Add("<Signature xmlns=\"http://www.w3.org/2000/09/xmldsig#\">");
			list2.Add("<SignedInfo>");
			list2.Add("<CanonicalizationMethod Algorithm=\"http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments\"/>");
			list2.Add("<SignatureMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#rsa-sha1\"/>");
			list2.Add("<Reference URI=\"#Terms\">");
			list2.Add("<Transforms>");
			list2.Add("<Transform Algorithm=\"http://www.w3.org/2000/09/xmldsig#enveloped-signature\"/>");
			list2.Add("</Transforms>");
			list2.Add("<DigestMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#sha1\"/>");
			list2.Add("<DigestValue>oeMc1KScgy617DHMPTxbYhqNjIM=</DigestValue>");
			list2.Add("</Reference>");
			list2.Add("</SignedInfo>");
			list2.Add("<SignatureValue>WuzMPTi0Ko1vffk9gf9ds/iU0b0K8UHaLpi4kWgm6q1am5MPTYYnzH1InaSWuzYo");
			list2.Add("EpJThKspOZdO0JISeEolNdJVf3JpsY55OsD8UaruvhwZn4r9pLeNSC7SzQ1rvAWP");
			list2.Add("h77XaHizhVVs15w6NYevP27LTxbZaem5L8Zs+34VKXQFeG4g0dEI/Jhl70TqE0CS");
			list2.Add("YNF+D0zqEtyMNHsh0Rq/vPLSzPXUN12jfPLZ3dO9B+9/mG7Ljd6emZjjLZUVuSKQ");
			list2.Add("uKxN5jlHZsm2kRMudijICV6YOWMPT+oZePlCg+BJQg5/xcN5aYVBDZhNeuNwQL1H");
			list2.Add("MPT/GJPxVuETgd9k8c4uDg==</SignatureValue>");
			list2.Add("</Signature>");
			list2.Add("</root>");
			string text2;
			if (version > 0)
			{
				text2 = "Unity_v5.x.ulf";
			}
			else
			{
				text2 = "Unity_v4.x.ulf";
			}
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Unity";
			if (spfold && !Directory.Exists(text3))
			{
				try
				{
					Directory.CreateDirectory(text3);
				}
				catch (Exception expr_398)
				{
					ProjectData.SetProjectError(expr_398);
					Exception ex = expr_398;
					spfold = false;
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
				}
			}
			if (spfold)
			{
				if (File.Exists(text3 + "/" + text2))
				{
					spfold = this.TestAtr(text3 + "/" + text2);
					if (spfold)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox(string.Format("Replace the \"{0}\\{1}\"?", text3, text2), MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
						if (dialogResult != DialogResult.Yes)
						{
							list2.Clear();
							result = true;
							return result;
						}
					}
				}
				if (spfold)
				{
					try
					{
						File.WriteAllLines(text3 + "/" + text2, list2);
					}
					catch (Exception expr_42B)
					{
						ProjectData.SetProjectError(expr_42B);
						Exception ex2 = expr_42B;
						spfold = false;
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (!spfold)
			{
				if (File.Exists(appDir + "/" + text2))
				{
					if (!this.TestAtr(appDir + "/" + text2))
					{
						list2.Clear();
						result = false;
						return result;
					}
					DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox(string.Format("Replace the \"{0}\\{1}\"?", appDir, text2), MsgBoxStyle.YesNo | MsgBoxStyle.Question, null);
					if (dialogResult2 != DialogResult.Yes)
					{
						list2.Clear();
						result = true;
						return result;
					}
				}
				try
				{
					File.WriteAllLines(appDir + "/" + text2, list2);
				}
				catch (Exception expr_4C3)
				{
					ProjectData.SetProjectError(expr_4C3);
					Exception ex3 = expr_4C3;
					list2.Clear();
					Interaction.MsgBox(ex3.Message, MsgBoxStyle.OkOnly, null);
					result = false;
					ProjectData.ClearProjectError();
					return result;
				}
			}
			list2.Clear();
			result = true;
		}
		return result;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (this.TextBox2.Text.Length <= 1)
		{
			this.TextBox2.Text = Application.StartupPath;
		}
		string text = this.TextBox2.Text;
		try
		{
			Directory.SetCurrentDirectory(text);
		}
		catch (Exception expr_37)
		{
			ProjectData.SetProjectError(expr_37);
			Exception ex = expr_37;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
			ProjectData.ClearProjectError();
			return;
		}
		this.Wrlc4x1(text, false, this.ComboBox1.SelectedIndex);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		VBMath.Randomize();
		checked
		{
			this.TextBox5.Text = Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]);
			VBMath.Randomize();
			this.TextBox6.Text = Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]);
			VBMath.Randomize();
			this.TextBox8.Text = Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]);
			VBMath.Randomize();
			this.TextBox9.Text = Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]);
			VBMath.Randomize();
			this.TextBox11.Text = Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]) + Conversions.ToString(text[(int)Math.Round((double)Conversion.Int(unchecked(35f * VBMath.Rnd() + 1f)))]);
		}
	}

	private void TextBox2_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox2.SelectedText.Length < 1)
		{
			this.TextBox2.SelectAll();
		}
	}

	private void TextBox4_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox4.SelectedText.Length < 1)
		{
			this.TextBox4.SelectAll();
		}
	}

	private void TextBox5_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox5.SelectedText.Length < 1)
		{
			this.TextBox5.SelectAll();
		}
	}

	private void TextBox6_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox6.SelectedText.Length < 1)
		{
			this.TextBox6.SelectAll();
		}
	}

	private void TextBox8_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox8.SelectedText.Length < 1)
		{
			this.TextBox8.SelectAll();
		}
	}

	private void TextBox9_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox9.SelectedText.Length < 1)
		{
			this.TextBox9.SelectAll();
		}
	}

	private void TextBox11_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.TextBox11.SelectedText.Length < 1)
		{
			this.TextBox11.SelectAll();
		}
	}

	private void TextBox4_TextChanged(object sender, EventArgs e)
	{
		if (this.TextBox4.Text.Length == this.TextBox4.MaxLength)
		{
			this.TextBox5.Select();
			this.TextBox5.SelectAll();
		}
	}

	private void TextBox5_TextChanged(object sender, EventArgs e)
	{
		if (this.TextBox5.Text.Length == this.TextBox5.MaxLength)
		{
			this.TextBox6.Select();
			this.TextBox6.SelectAll();
		}
	}

	private void TextBox6_TextChanged(object sender, EventArgs e)
	{
		if (this.TextBox6.Text.Length == this.TextBox6.MaxLength)
		{
			this.TextBox8.Select();
			this.TextBox8.SelectAll();
		}
	}

	private void TextBox8_TextChanged(object sender, EventArgs e)
	{
		if (this.TextBox8.Text.Length == this.TextBox8.MaxLength)
		{
			this.TextBox9.Select();
			this.TextBox9.SelectAll();
		}
	}

	private void TextBox9_TextChanged(object sender, EventArgs e)
	{
		if (this.TextBox9.Text.Length == this.TextBox9.MaxLength)
		{
			this.TextBox11.Select();
			this.TextBox11.SelectAll();
		}
	}

	private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextBox9.Text.Length == 0 && e.KeyChar == '\b')
		{
			this.TextBox8.Select();
			this.TextBox8.SelectAll();
		}
	}

	private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextBox8.Text.Length == 0 && e.KeyChar == '\b')
		{
			this.TextBox6.Select();
			this.TextBox6.SelectAll();
		}
	}

	private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextBox6.Text.Length == 0 && e.KeyChar == '\b')
		{
			this.TextBox5.Select();
			this.TextBox5.SelectAll();
		}
	}

	private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextBox5.Text.Length == 0 && e.KeyChar == '\b')
		{
			this.TextBox4.Select();
			this.TextBox4.SelectAll();
		}
	}

	private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextBox11.Text.Length == 0 && e.KeyChar == '\b')
		{
			this.TextBox9.Select();
			this.TextBox9.SelectAll();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long IsDebuggerPresent();

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Form_Load()
	{
		if (Form1.IsDebuggerPresent() != 0L)
		{
			ProjectData.EndApp();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Form2.ShowDialog(this);
	}
}
