using Xamarin.Forms;
using System.Reflection;

namespace XamarinBeispiele.Images
{
    internal class claImageResourceResolver
    {
        public static void DebugResources()
        {
            var assembly = typeof(claImageResourceResolver).GetTypeInfo().Assembly;

            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }
        }

        public static ImageSource ResolveImage(string ImageName)
        {
            return ImageSource.FromResource($"XamarinBeispiele.Images.{ImageName}.png", Assembly.GetExecutingAssembly());
        }

        public static ImageSource ResolveGif(string ImageName)
        {
            return ImageSource.FromResource($"XamarinBeispiele.Images.{ImageName}.gif", Assembly.GetExecutingAssembly());
        }
    }
}
