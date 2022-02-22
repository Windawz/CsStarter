namespace CsStarter.DataOps
{
    public interface IExporter
    {
        void Export(object? data, string path);
    }
}
