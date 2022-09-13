using daydream.Utils;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace daydream.Protection.Anti
{
    public class VirtualMachine
    {
        /* 
        * CheckEnvironment - Checks if the environment is a virtual machine
        */
        public static void CheckEnvironment()
        {
            // Create a new list with the environment variables
            var environmentVariables = new Dictionary<string, string>();

            // Set the environment variables
            environmentVariables.Add("VBOX_INSTALL_PATH", "VirtualBox");
            environmentVariables.Add("SANDBOXIE_HOME", "Sandboxie");
            environmentVariables.Add("VBOX_MSI_INSTALL_PATH", "VirtualBox");
            environmentVariables.Add("VBOX_USER_HOME", "VirtualBox");
            environmentVariables.Add("VBOX_USER_HOME_PATH", "VirtualBox");

            // Loop through the environment variables
            foreach (var environmentVariable in environmentVariables)
            {
                // Check if environment variable is set
                if (Environment.GetEnvironmentVariable(environmentVariable.Key) != null)
                {
                    // If Environment variable is found then exit
                    Environment.Exit(0);
                }
            }

            Logger.Write("No virtual machine environment variables found!", Logger.LogLevel.Info);

        }

        /* 
        * CheckMacAddress - Checks if the mac address is a virtual machine
        */
        public static void CheckMacAddress()
        {
            // Create a new list with the mac addresses
            var macAddresses = new Dictionary<string, string>();

            // Set the mac addresses
            macAddresses.Add("08:00:27", "Oracle Corporation");
            macAddresses.Add("0A:00:27", "Oracle Corporation");
            macAddresses.Add("0E:00:27", "Oracle Corporation");
            macAddresses.Add("00:05:69", "VMware, Inc.");
            macAddresses.Add("00:0C:29", "VMware, Inc.");
            macAddresses.Add("00:50:56", "VMware, Inc.");
            macAddresses.Add("00:1C:14", "VMware, Inc.");
            macAddresses.Add("00:0F:4B", "VMware, Inc.");
            macAddresses.Add("00:16:3E", "VMware, Inc.");

            // Loop through the mac addresses
            foreach (var macAddress in macAddresses)
            {
                // Get the mac address
                if (NetworkInterface.GetAllNetworkInterfaces().Any(nic => nic.GetPhysicalAddress().ToString().StartsWith(macAddress.Key)))
                {
                    // If Mac address found then exit
                    Environment.Exit(0);
                }
            }

            Logger.Write("No virtual machine MAC addresses found!", Logger.LogLevel.Info);
        }

        /*
        * CheckProcess - Checks if the process is a virtual machine
        */
        public static void CheckProcess()
        {

            // Create a new list with the process names
            var virtualMachineProcess = new Dictionary<string, string>();

            // Examples
            virtualMachineProcess.Add("VBoxService", "VirtualBox");
            virtualMachineProcess.Add("VBoxTray", "VirtualBox");
            virtualMachineProcess.Add("vmtoolsd", "VMware");
            virtualMachineProcess.Add("vmacthlp", "VMware");
            virtualMachineProcess.Add("vmware-vmx", "VMware");
            virtualMachineProcess.Add("vmware-vmx-stats", "VMware");
            virtualMachineProcess.Add("vmware-vmx-debug", "VMware");
            virtualMachineProcess.Add("vmware-unity-support", "VMware");
            virtualMachineProcess.Add("vmware-authd", "VMware");
            virtualMachineProcess.Add("sandboxie-svc", "Sandboxie");
            virtualMachineProcess.Add("sandboxie-boxed", "Sandboxie");

            // Loop through the dictionary
            foreach (string process in virtualMachineProcess.Keys)
            {
                // Check if the process is running
                if (Process.GetProcessesByName(process).Length > 0)
                {
                    Environment.Exit(0);
                }
            }

            Logger.Write("No virtual machine processes found!", Logger.LogLevel.Info);
        }
    }
}