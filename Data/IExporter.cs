namespace CsStarter.Data
{
    public interface IExporter
    {
        void Export(object? data, string path);
    }
}
