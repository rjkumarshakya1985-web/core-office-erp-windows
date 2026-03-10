namespace CoreOffice.Win.Shared
{
    public static class AppLoader
    {
        private static FrmLoader loader;

        public static void Show()
        {
            if (loader == null || loader.IsDisposed)
            {
                loader = new FrmLoader();
                loader.Show();
                loader.Refresh();
            }
        }

        public static void Hide()
        {
            if (loader != null && !loader.IsDisposed)
            {
                loader.Close();
            }
        }
    }
}
