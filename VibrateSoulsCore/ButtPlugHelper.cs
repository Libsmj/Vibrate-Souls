using Buttplug.Client;
using System.Diagnostics;

namespace VibrateSoulsCore
{
    public class ButtPlugHelper
    {
        public string ServerAddress;
        public readonly ButtplugClient BpClient;

        public EventHandler? ConnectionAttemptFinished;
        public EventHandler? DeviceListChanged;

        public ButtPlugHelper(string serverAddress)
        {
            ServerAddress = serverAddress;
            BpClient = new("Vibrate Souls");
            BpClient.ServerDisconnect += OnDisconnect;
            BpClient.DeviceAdded += OnDeviceAdded;
            BpClient.DeviceRemoved += OnDeviceRemoved;
        }

        private void OnDisconnect(object? sender, EventArgs e)
        {
            ConnectionAttemptFinished?.Invoke(this, EventArgs.Empty);
        }

        private void OnDeviceAdded(object? sender, DeviceAddedEventArgs e)
        {
            DeviceListChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnDeviceRemoved(object? sender, DeviceRemovedEventArgs e)
        {
            DeviceListChanged?.Invoke(this, EventArgs.Empty);
        }

        public async void InitializeClient()
        {
            if (BpClient.Connected)
            {
                return;
            }
            try
            {
                ButtplugWebsocketConnector connector = new(new Uri(ServerAddress));
                await BpClient.ConnectAsync(connector);
            }
            catch (Exception e) 
            { 
                Debug.WriteLine(e);
            }
            ConnectionAttemptFinished?.Invoke(this, EventArgs.Empty);
        }

        public async void VibrateAll()
        {
            if (BpClient.Devices.Length == 0)
            {
                return;
            }
            try
            {
                foreach (ButtplugClientDevice? device in BpClient.Devices)
                {
                    await device.VibrateAsync(1);
                }

                await Task.Delay(1000);
                await BpClient.StopAllDevicesAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
