namespace WpfExplorer
{
    /*
        App.xaml 파일을 폐기함으로 인해, 더 이상 자동으로 프로그램을 실행하는 것이 불가능하게 됨.
        따라서 App를 생성하기 위해서는 프로그램 시작점을 별도로 구현해야 한다.
     */
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }

    }
}
