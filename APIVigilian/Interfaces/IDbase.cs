namespace APIVigilian.Interfaces
{
    public interface IDbase
    {
        public void Conectar();
        public void Desconectar();
        public  InsertComandSQL(string cmdsql);
    }
}