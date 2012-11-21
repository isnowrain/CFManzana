using System;
using System.Collections.Generic;
using System.Text;

using CoreFoundation;
using CFManzana;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFManzana by iSn0wra1n");

            iDevice dev = new iDevice();

        /* Reads various device settings. Values can be
         
        * ActivationPublicKey 
        * ActivationState 
        * ActivationStateAcknowledged 
        * ActivityURL 
        * BasebandBootloaderVersion 
        * BasebandSerialNumber 
        * BasebandStatus 
        * BasebandVersion 
        * BluetoothAddress 
        * BuildVersion 
        * CPUArchitecture 
        * DeviceCertificate 
        * DeviceClass 
        * DeviceColor 
        * DeviceName 
        * DevicePublicKey 
        * DieID 
        * FirmwareVersion 
        * HardwareModel 
        * HardwarePlatform 
        * HostAttached 
        * IMLockdownEverRegisteredKey 
        * IntegratedCircuitCardIdentity 
        * InternationalMobileEquipmentIdentity 
        * InternationalMobileSubscriberIdentity 
        * iTunesHasConnected 
        * MLBSerialNumber 
        * MobileSubscriberCountryCode 
        * MobileSubscriberNetworkCode 
        * ModelNumber 
        * PartitionType 
        * PasswordProtected 
        * PhoneNumber 
        * ProductionSOC 
        * ProductType 
        * ProductVersion 
        * ProtocolVersion 
        * ProximitySensorCalibration 
        * RegionInfo 
        * SBLockdownEverRegisteredKey 
        * SerialNumber 
        * SIMStatus 
        * SoftwareBehavior 
        * SoftwareBundleVersion 
        * SupportedDeviceFamilies 
        * TelephonyCapability 
        * TimeIntervalSince1970 
        * TimeZone 
        * TimeZoneOffsetFromUTC 
        * TrustedHostAttached 
        * UniqueChipID 
        * UniqueDeviceID 
        * UseActivityURL 
        * UseRaptorCerts 
        * Uses24HourClock 
        * WeDelivered 
        * WiFiAddress
         * */
            Console.WriteLine("\nDevice Name: " + dev.CopyValue("DeviceName"));
            Console.WriteLine("Device iOS Version: " + dev.CopyValue("ProductVersion"));            
            System.Threading.Thread.Sleep(-1);
        }
    }
}
