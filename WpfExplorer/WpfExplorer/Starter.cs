using WpfExplorer.Properties;

namespace WpfExplorer
{
    internal class Starter
    {
        /// <summary>
        /// 프로그램의 진입정 설정
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<HelperModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
