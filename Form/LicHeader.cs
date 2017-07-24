using System;
using System.Collections.Generic;

public class LicHeader
{
	public class LicSettings
	{
		public int type;

		public bool team;

		public int iPhone;

		public int Android;

		public int Flash;

		public int WinStore;

		public int Blackberry;

		public bool Xbox;

		public bool PlayStation;

		public bool Wii;

		public bool educt;

		public bool nrelerase;

		public int Tizen;

		public int SamsungTV;

		public bool psm;

		public LicSettings()
		{
			this.type = 0;
			this.team = true;
			this.iPhone = 0;
			this.Android = 0;
			this.Flash = 0;
			this.WinStore = 0;
			this.Blackberry = 0;
			this.Xbox = false;
			this.PlayStation = false;
			this.Wii = false;
			this.educt = false;
			this.nrelerase = false;
			this.Tizen = 2;
			this.SamsungTV = 2;
			this.psm = false;
		}
	}

	private static LicHeader.LicSettings lic_Settings = new LicHeader.LicSettings();

	public static LicHeader.LicSettings PropLicSettings
	{
		get
		{
			return LicHeader.lic_Settings;
		}
		set
		{
			LicHeader.lic_Settings = value;
		}
	}

	public static List<int> ReadAll()
	{
		List<int> list = new List<int>();
		if (LicHeader.lic_Settings.type == 0)
		{
			list.Add(0);
			list.Add(1);
			list.Add(16);
		}
		else if (LicHeader.lic_Settings.type == 1)
		{
			list.Add(0);
			list.Add(1);
		}
		else if (LicHeader.lic_Settings.type == 2)
		{
			list.Add(62);
		}
		if (LicHeader.lic_Settings.team)
		{
			list.Add(2);
		}
		if (LicHeader.lic_Settings.iPhone == 0)
		{
			list.Add(3);
			list.Add(4);
		}
		else if (LicHeader.lic_Settings.iPhone == 1)
		{
			list.Add(3);
		}
		if (LicHeader.lic_Settings.Xbox)
		{
			list.Add(5);
		}
		if (LicHeader.lic_Settings.PlayStation)
		{
			list.Add(6);
		}
		if (LicHeader.lic_Settings.Wii)
		{
			list.Add(8);
		}
		if (LicHeader.lic_Settings.nrelerase)
		{
			list.Add(61);
		}
		if (LicHeader.lic_Settings.educt)
		{
			list.Add(63);
		}
		if (LicHeader.lic_Settings.Android == 0)
		{
			list.Add(12);
			list.Add(13);
		}
		else if (LicHeader.lic_Settings.Android == 1)
		{
			list.Add(12);
		}
		if (LicHeader.lic_Settings.Flash == 0)
		{
			list.Add(14);
			list.Add(15);
		}
		else if (LicHeader.lic_Settings.Flash == 1)
		{
			list.Add(14);
		}
		if (LicHeader.lic_Settings.WinStore == 0)
		{
			list.Add(19);
			list.Add(20);
		}
		else if (LicHeader.lic_Settings.WinStore == 1)
		{
			list.Add(19);
		}
		if (LicHeader.lic_Settings.SamsungTV == 0)
		{
			list.Add(24);
			list.Add(25);
		}
		else if (LicHeader.lic_Settings.SamsungTV == 1)
		{
			list.Add(24);
		}
		if (LicHeader.lic_Settings.Blackberry == 0)
		{
			list.Add(17);
			list.Add(18);
		}
		else if (LicHeader.lic_Settings.Blackberry == 1)
		{
			list.Add(17);
		}
		if (LicHeader.lic_Settings.Tizen == 0)
		{
			list.Add(33);
			list.Add(34);
		}
		else if (LicHeader.lic_Settings.Tizen == 1)
		{
			list.Add(33);
		}
		if (LicHeader.lic_Settings.psm)
		{
			list.Add(36);
		}
		list.Sort();
		return list;
	}
}
