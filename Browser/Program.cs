﻿/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/6/28
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using WeifenLuo.WinFormsUI.Docking;

namespace Lextm.SharpSnmpLib.Browser
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal static class Program
	{
	    private static IUnityContainer container;

	    internal static IUnityContainer Container
	    {
	        get { return container; }
	    }

	    /// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
            container = new UnityContainer();
            UnityConfigurationSection section
              = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Containers.Default.Configure(Container);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		    Application.Run(new MainForm());
		}
	}
}