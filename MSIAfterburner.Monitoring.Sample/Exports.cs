using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MSIAfterburner.Monitoring.Sample
{
    public class Exports
    {
        /////////////////////////////////////////////////////////////////////////////
        // This exported function is called by MSI Afterburner to check if a source
        // provides any additional settings and for customizing it when <Setup>
        // button is clicked in the source's properties 
        //
        // The function is called with hWnd = NULL during checking and with parent
        // window's hWnd during customization
        //
        // The function is called with valid source index to customize specific
        // source or 0xFFFFFFFF to customize whole plugin 
        /////////////////////////////////////////////////////////////////////////////
        [DllExport]
        public static bool SetupSource(uint dwIndex, IntPtr hWnd)
        {
            if (hWnd != IntPtr.Zero)
            {
                if (dwIndex == 0xFFFFFFFF)
                {
                    //global plugin setup

                    Forms.frmSetupGlobal frmSetup = new Forms.frmSetupGlobal();
                    frmSetup.ShowDialog();

                    return true;
                }
                else
                {
                    //specific data source setup

                    Forms.frmSetupSpecific frmSpecific = new Forms.frmSetupSpecific((int)dwIndex);
                    frmSpecific.ShowDialog();

                    return true;
                }
            }
            else
            {
                //hWnd is NULL, simply return TRUE as all the sources exported by our plugin
                //have additional properties
                return true;
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        // This exported function is called by MSI Afterburner to get a number of
        // data sources in this plugin
        /////////////////////////////////////////////////////////////////////////////
        [DllExport]
        public static uint GetSourcesNum()
        {
            return (uint)MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames.Length;
        }

        /////////////////////////////////////////////////////////////////////////////
        // This exported function is called by MSI Afterburner to get descriptor
        // for the specified data source
        /////////////////////////////////////////////////////////////////////////////
        [DllExport]
        public static bool GetSourceDesc(uint dwIndex, ref SourceDescription pDesc)
        {
            if (dwIndex >= 0)
            {
                string[] names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames;
                

                pDesc.szName = names[(int)dwIndex];
                pDesc.szUnits = "°C";
                pDesc.szGroup = "Test Group";

                pDesc.dwID = SourceIDPluginEnum.Misc;
                pDesc.dwInstance = 0;

                pDesc.fltMaxLimit = 100;
                pDesc.fltMinLimit = 0;

                return true;
            }

            return false;
        }

        /////////////////////////////////////////////////////////////////////////////
        // This exported function is called by MSI Afterburner to poll data 
        // sources
        /////////////////////////////////////////////////////////////////////////////
        [DllExport]
        public static float GetSourceData(uint dwIndex)
        {
            if (dwIndex >= 0)
            {
                float[] values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues;
                return values[(int)dwIndex];
            }

            return 0f;
        }
    }
}
