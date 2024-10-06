namespace study_this_framework.IBase
{
    public class GenericRequest<T> 
    {
        public List<T>? Inserts { get; set; }   // Esto es público y accesible desde fuera de la clase
        public List<T>? Updates { get; set; }   // Esto también es público
        public List<T>? Deletes { get; set; }   // Esto también es público


    }
}
