using APIVigilian.Interfaces;

namespace APIVigilian.Repository
{
    public class Dbase : IDbase
    {
        private string _conn;
        public Dbase(string coon)
        {
            _conn = coon;
        }
        public void Conectar() 
        {
            
        }
        public void Desconectar() 
        {
            
            
        }
    }
}
