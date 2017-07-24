using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Ok")]
	private Button _Ok;

	[AccessedThroughProperty("Cancel")]
	private Button _Cancel;

	[AccessedThroughProperty("type")]
	private ComboBox _type;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Team")]
	private CheckBox _Team;

	[AccessedThroughProperty("Wii")]
	private CheckBox _Wii;

	[AccessedThroughProperty("iPhone")]
	private ComboBox _iPhone;

	[AccessedThroughProperty("Android")]
	private ComboBox _Android;

	[AccessedThroughProperty("Flash")]
	private ComboBox _Flash;

	[AccessedThroughProperty("WinStore")]
	private ComboBox _WinStore;

	[AccessedThroughProperty("Blackberry")]
	private ComboBox _Blackberry;

	[AccessedThroughProperty("Xbox")]
	private CheckBox _Xbox;

	[AccessedThroughProperty("PlayStation")]
	private CheckBox _PlayStation;

	[AccessedThroughProperty("nrelerase")]
	private CheckBox _nrelerase;

	[AccessedThroughProperty("educt")]
	private CheckBox _educt;

	[AccessedThroughProperty("Tizen")]
	private ComboBox _Tizen;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("SamsungTV")]
	private ComboBox _SamsungTV;

	[AccessedThroughProperty("psm")]
	private CheckBox _psm;

	private LicHeader.LicSettings lic_Settings;

	internal virtual Button Ok
	{
		get
		{
			return this._Ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button1_Click);
			if (this._Ok != null)
			{
				this._Ok.Click -= value2;
			}
			this._Ok = value;
			if (this._Ok != null)
			{
				this._Ok.Click += value2;
			}
		}
	}

	internal virtual Button Cancel
	{
		get
		{
			return this._Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.Button2_Click);
			if (this._Cancel != null)
			{
				this._Cancel.Click -= value2;
			}
			this._Cancel = value;
			if (this._Cancel != null)
			{
				this._Cancel.Click += value2;
			}
		}
	}

	internal virtual ComboBox Type
	{
		get
		{
			return this._type;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._type = value;
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

	internal virtual CheckBox Team
	{
		get
		{
			return this._Team;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Team = value;
		}
	}

	internal virtual CheckBox Wii
	{
		get
		{
			return this._Wii;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Wii = value;
		}
	}

	internal virtual ComboBox IPhone
	{
		get
		{
			return this._iPhone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._iPhone = value;
		}
	}

	internal virtual ComboBox Android
	{
		get
		{
			return this._Android;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Android = value;
		}
	}

	internal virtual ComboBox Flash
	{
		get
		{
			return this._Flash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Flash = value;
		}
	}

	internal virtual ComboBox WinStore
	{
		get
		{
			return this._WinStore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._WinStore = value;
		}
	}

	internal virtual ComboBox Blackberry
	{
		get
		{
			return this._Blackberry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Blackberry = value;
		}
	}

	internal virtual CheckBox Xbox
	{
		get
		{
			return this._Xbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Xbox = value;
		}
	}

	internal virtual CheckBox PlayStation
	{
		get
		{
			return this._PlayStation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._PlayStation = value;
		}
	}

	internal virtual CheckBox Nrelerase
	{
		get
		{
			return this._nrelerase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._nrelerase = value;
		}
	}

	internal virtual CheckBox Educt
	{
		get
		{
			return this._educt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._educt = value;
		}
	}

	internal virtual ComboBox Tizen
	{
		get
		{
			return this._Tizen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Tizen = value;
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

	internal virtual ComboBox SamsungTV
	{
		get
		{
			return this._SamsungTV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._SamsungTV = value;
		}
	}

	internal virtual CheckBox Psm
	{
		get
		{
			return this._psm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._psm = value;
		}
	}

	public Form2()
	{
		base.Load += new EventHandler(this.Form2_Load);
		this.lic_Settings = new LicHeader.LicSettings();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		this.Ok = new Button();
		this.Cancel = new Button();
		this.Type = new ComboBox();
		this.Label1 = new Label();
		this.Label2 = new Label();
		this.Team = new CheckBox();
		this.Wii = new CheckBox();
		this.IPhone = new ComboBox();
		this.Android = new ComboBox();
		this.Flash = new ComboBox();
		this.WinStore = new ComboBox();
		this.Blackberry = new ComboBox();
		this.Xbox = new CheckBox();
		this.PlayStation = new CheckBox();
		this.Nrelerase = new CheckBox();
		this.Educt = new CheckBox();
		this.Tizen = new ComboBox();
		this.ToolTip1 = new ToolTip(this.components);
		this.SamsungTV = new ComboBox();
		this.Psm = new CheckBox();
		this.SuspendLayout();
		this.Ok.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.Ok.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_149_0 = this.Ok;
		Point location = new Point(243, 363);
		arg_149_0.Location = location;
		this.Ok.Name = "Ok";
		Control arg_171_0 = this.Ok;
		Size size = new Size(75, 23);
		arg_171_0.Size = size;
		this.Ok.TabIndex = 0;
		this.Ok.Text = "Ok";
		this.Ok.UseVisualStyleBackColor = true;
		this.Cancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.Cancel.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_1E4_0 = this.Cancel;
		location = new Point(162, 363);
		arg_1E4_0.Location = location;
		this.Cancel.Name = "Cancel";
		Control arg_20C_0 = this.Cancel;
		size = new Size(75, 23);
		arg_20C_0.Size = size;
		this.Cancel.TabIndex = 1;
		this.Cancel.Text = "Cancel";
		this.Cancel.UseVisualStyleBackColor = true;
		this.Type.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Type.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Type.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.Type.FormattingEnabled = true;
		this.Type.Items.AddRange(new object[]
		{
			"Unity for Embedded Systems",
			"Unity Pro",
			"Unity",
			"Unity Indie"
		});
		Control arg_2CF_0 = this.Type;
		location = new Point(54, 12);
		arg_2CF_0.Location = location;
		this.Type.Name = "type";
		Control arg_2FA_0 = this.Type;
		size = new Size(264, 23);
		arg_2FA_0.Size = size;
		this.Type.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_34A_0 = this.Label1;
		location = new Point(12, 15);
		arg_34A_0.Location = location;
		this.Label1.Name = "Label1";
		Control arg_372_0 = this.Label1;
		size = new Size(36, 15);
		arg_372_0.Size = size;
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Type:";
		this.Label2.AutoSize = true;
		this.Label2.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_3D2_0 = this.Label2;
		location = new Point(12, 49);
		arg_3D2_0.Location = location;
		this.Label2.Name = "Label2";
		Control arg_3FA_0 = this.Label2;
		size = new Size(60, 15);
		arg_3FA_0.Size = size;
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Features:";
		this.Team.AutoSize = true;
		this.Team.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_45A_0 = this.Team;
		location = new Point(12, 77);
		arg_45A_0.Location = location;
		this.Team.Name = "Team";
		Control arg_482_0 = this.Team;
		size = new Size(57, 19);
		arg_482_0.Size = size;
		this.Team.TabIndex = 5;
		this.Team.Text = "Team";
		this.Team.UseVisualStyleBackColor = true;
		this.Wii.AutoSize = true;
		this.Wii.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_4EE_0 = this.Wii;
		location = new Point(75, 77);
		arg_4EE_0.Location = location;
		this.Wii.Name = "Wii";
		Control arg_516_0 = this.Wii;
		size = new Size(44, 19);
		arg_516_0.Size = size;
		this.Wii.TabIndex = 11;
		this.Wii.Text = "Wii";
		this.Wii.UseVisualStyleBackColor = true;
		this.IPhone.DropDownStyle = ComboBoxStyle.DropDownList;
		this.IPhone.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.IPhone.FormattingEnabled = true;
		this.IPhone.Items.AddRange(new object[]
		{
			"iPhone Pro",
			"iPhone",
			"None"
		});
		Control arg_5C7_0 = this.IPhone;
		location = new Point(12, 152);
		arg_5C7_0.Location = location;
		this.IPhone.Name = "iPhone";
		Control arg_5F2_0 = this.IPhone;
		size = new Size(159, 23);
		arg_5F2_0.Size = size;
		this.IPhone.TabIndex = 12;
		this.Android.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Android.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.Android.FormattingEnabled = true;
		this.Android.Items.AddRange(new object[]
		{
			"Android Pro",
			"Android",
			"None"
		});
		Control arg_687_0 = this.Android;
		location = new Point(12, 181);
		arg_687_0.Location = location;
		this.Android.Name = "Android";
		Control arg_6B2_0 = this.Android;
		size = new Size(159, 23);
		arg_6B2_0.Size = size;
		this.Android.TabIndex = 13;
		this.Flash.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Flash.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.Flash.FormattingEnabled = true;
		this.Flash.Items.AddRange(new object[]
		{
			"Flash Pro",
			"Flash",
			"None"
		});
		Control arg_747_0 = this.Flash;
		location = new Point(12, 239);
		arg_747_0.Location = location;
		this.Flash.Name = "Flash";
		Control arg_772_0 = this.Flash;
		size = new Size(159, 23);
		arg_772_0.Size = size;
		this.Flash.TabIndex = 14;
		this.WinStore.DropDownStyle = ComboBoxStyle.DropDownList;
		this.WinStore.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.WinStore.FormattingEnabled = true;
		this.WinStore.Items.AddRange(new object[]
		{
			"WinStore Pro",
			"WinStore",
			"None"
		});
		Control arg_807_0 = this.WinStore;
		location = new Point(12, 268);
		arg_807_0.Location = location;
		this.WinStore.Name = "WinStore";
		Control arg_832_0 = this.WinStore;
		size = new Size(159, 23);
		arg_832_0.Size = size;
		this.WinStore.TabIndex = 15;
		this.Blackberry.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Blackberry.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.Blackberry.FormattingEnabled = true;
		this.Blackberry.Items.AddRange(new object[]
		{
			"Blackberry Pro",
			"Blackberry",
			"None"
		});
		Control arg_8C7_0 = this.Blackberry;
		location = new Point(12, 210);
		arg_8C7_0.Location = location;
		this.Blackberry.Name = "Blackberry";
		Control arg_8F2_0 = this.Blackberry;
		size = new Size(159, 23);
		arg_8F2_0.Size = size;
		this.Blackberry.TabIndex = 16;
		this.Xbox.AutoSize = true;
		this.Xbox.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_943_0 = this.Xbox;
		location = new Point(127, 77);
		arg_943_0.Location = location;
		this.Xbox.Name = "Xbox";
		Control arg_96B_0 = this.Xbox;
		size = new Size(79, 19);
		arg_96B_0.Size = size;
		this.Xbox.TabIndex = 18;
		this.Xbox.Text = "Xbox 360";
		this.Xbox.UseVisualStyleBackColor = true;
		this.PlayStation.AutoSize = true;
		this.PlayStation.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_9DB_0 = this.PlayStation;
		location = new Point(212, 77);
		arg_9DB_0.Location = location;
		this.PlayStation.Name = "PlayStation";
		Control arg_A03_0 = this.PlayStation;
		size = new Size(100, 19);
		arg_A03_0.Size = size;
		this.PlayStation.TabIndex = 19;
		this.PlayStation.Text = "PlayStation 3";
		this.PlayStation.UseVisualStyleBackColor = true;
		this.Nrelerase.AutoSize = true;
		this.Nrelerase.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_A70_0 = this.Nrelerase;
		location = new Point(12, 102);
		arg_A70_0.Location = location;
		this.Nrelerase.Name = "nrelerase";
		Control arg_A98_0 = this.Nrelerase;
		size = new Size(110, 19);
		arg_A98_0.Size = size;
		this.Nrelerase.TabIndex = 20;
		this.Nrelerase.Text = "Not for release";
		this.Nrelerase.UseVisualStyleBackColor = true;
		this.Educt.AutoSize = true;
		this.Educt.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_B05_0 = this.Educt;
		location = new Point(12, 127);
		arg_B05_0.Location = location;
		this.Educt.Name = "educt";
		Control arg_B30_0 = this.Educt;
		size = new Size(163, 19);
		arg_B30_0.Size = size;
		this.Educt.TabIndex = 21;
		this.Educt.Text = "For educational use only";
		this.Educt.UseVisualStyleBackColor = true;
		this.Tizen.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Tizen.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.Tizen.FormattingEnabled = true;
		this.Tizen.Items.AddRange(new object[]
		{
			"Tizen Pro",
			"Tizen",
			"None"
		});
		Control arg_BE1_0 = this.Tizen;
		location = new Point(12, 297);
		arg_BE1_0.Location = location;
		this.Tizen.Name = "Tizen";
		Control arg_C0C_0 = this.Tizen;
		size = new Size(159, 23);
		arg_C0C_0.Size = size;
		this.Tizen.TabIndex = 22;
		this.ToolTip1.SetToolTip(this.Tizen, "Unity 4.3.x Feature");
		this.SamsungTV.DropDownStyle = ComboBoxStyle.DropDownList;
		this.SamsungTV.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.SamsungTV.FormattingEnabled = true;
		this.SamsungTV.Items.AddRange(new object[]
		{
			"Samsung TV Pro",
			"Samsung TV",
			"None"
		});
		Control arg_CB7_0 = this.SamsungTV;
		location = new Point(12, 326);
		arg_CB7_0.Location = location;
		this.SamsungTV.Name = "SamsungTV";
		Control arg_CE2_0 = this.SamsungTV;
		size = new Size(159, 23);
		arg_CE2_0.Size = size;
		this.SamsungTV.TabIndex = 23;
		this.ToolTip1.SetToolTip(this.SamsungTV, "Unity 4.5.x Feature");
		this.Psm.AutoSize = true;
		this.Psm.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
		Control arg_D4C_0 = this.Psm;
		location = new Point(212, 102);
		arg_D4C_0.Location = location;
		this.Psm.Name = "psm";
		Control arg_D74_0 = this.Psm;
		size = new Size(117, 19);
		arg_D74_0.Size = size;
		this.Psm.TabIndex = 24;
		this.Psm.Text = "PlayStation Mob";
		this.ToolTip1.SetToolTip(this.Psm, "Unity 4.3.4x Feature");
		this.Psm.UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		this.AutoScaleDimensions = autoScaleDimensions;
		this.AutoScaleMode = AutoScaleMode.Font;
		size = new Size(330, 398);
		this.ClientSize = size;
		this.Controls.Add(this.Psm);
		this.Controls.Add(this.SamsungTV);
		this.Controls.Add(this.Tizen);
		this.Controls.Add(this.Educt);
		this.Controls.Add(this.Nrelerase);
		this.Controls.Add(this.PlayStation);
		this.Controls.Add(this.Xbox);
		this.Controls.Add(this.Blackberry);
		this.Controls.Add(this.WinStore);
		this.Controls.Add(this.Flash);
		this.Controls.Add(this.Android);
		this.Controls.Add(this.IPhone);
		this.Controls.Add(this.Wii);
		this.Controls.Add(this.Team);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Type);
		this.Controls.Add(this.Cancel);
		this.Controls.Add(this.Ok);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "Form2";
		this.StartPosition = FormStartPosition.CenterParent;
		this.Text = "License Settings";
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		this.lic_Settings = LicHeader.PropLicSettings;
		this.Type.SelectedIndex = this.lic_Settings.type;
		this.Android.SelectedIndex = this.lic_Settings.Android;
		this.Blackberry.SelectedIndex = this.lic_Settings.Blackberry;
		this.Flash.SelectedIndex = this.lic_Settings.Flash;
		this.IPhone.SelectedIndex = this.lic_Settings.iPhone;
		this.PlayStation.Checked = this.lic_Settings.PlayStation;
		this.Wii.Checked = this.lic_Settings.Wii;
		this.WinStore.SelectedIndex = this.lic_Settings.WinStore;
		this.Xbox.Checked = this.lic_Settings.Xbox;
		this.Team.Checked = this.lic_Settings.team;
		this.Tizen.SelectedIndex = this.lic_Settings.Tizen;
		this.SamsungTV.SelectedIndex = this.lic_Settings.SamsungTV;
		this.Psm.Checked = this.lic_Settings.psm;
		this.Educt.Checked = this.lic_Settings.educt;
		this.Nrelerase.Checked = this.lic_Settings.nrelerase;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		this.lic_Settings.type = this.Type.SelectedIndex;
		this.lic_Settings.Android = this.Android.SelectedIndex;
		this.lic_Settings.Blackberry = this.Blackberry.SelectedIndex;
		this.lic_Settings.Flash = this.Flash.SelectedIndex;
		this.lic_Settings.iPhone = this.IPhone.SelectedIndex;
		this.lic_Settings.PlayStation = this.PlayStation.Checked;
		this.lic_Settings.Wii = this.Wii.Checked;
		this.lic_Settings.WinStore = this.WinStore.SelectedIndex;
		this.lic_Settings.Xbox = this.Xbox.Checked;
		this.lic_Settings.team = this.Team.Checked;
		this.lic_Settings.Tizen = this.Tizen.SelectedIndex;
		this.lic_Settings.SamsungTV = this.SamsungTV.SelectedIndex;
		this.lic_Settings.psm = this.Psm.Checked;
		this.lic_Settings.educt = this.Educt.Checked;
		this.lic_Settings.nrelerase = this.Nrelerase.Checked;
		LicHeader.PropLicSettings = this.lic_Settings;
		this.Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		this.Close();
	}
}
