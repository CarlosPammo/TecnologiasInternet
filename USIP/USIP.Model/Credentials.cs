namespace USIP.Model
{
	public class Credentials
	{

        public int Id { get; set; }
        public int IdUser { get; set; }
        public string UserName { get; set; }
		public string Password { get; set; }
        public int IdRol { get; set; }
       // public bool Estate { get; set; }
        //public TypeRol Rols { get; set; }

        public virtual User User { get; set; }
        public virtual RolMain RolMain { get; set; }

    }
}
