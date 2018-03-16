using System;

namespace EstudioAC.Model
{
    public class Servico
    {
        public int id { get; set; }
        public string servicoPrestado { get; set; }
        public double valor { get; set; }
        public DateTime data { get; set;}
        
        
        
        //{ get { return Convert.ToDateTime(data.ToString("d"))}; set; }
    }
}
