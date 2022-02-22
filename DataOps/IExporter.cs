namespace CSStarter.DataOps
{
    public interface IExporter
    {
        void Export(object? data, string path);
    }
}
