namespace Aula201.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }

        public abstract void processDoc(string document);
    }
}
