using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;
namespace BLE.Client.Helpers
{
    public interface IPlatformHelpers
    {
        Task<PermissionStatus> CheckAndRequestBluetoothPermissions();
    }
}
