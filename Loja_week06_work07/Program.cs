namespace Loja_week06_work07;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form_EquipmentManager());
    }
}
