namespace SolucionPizza.DTO.Common;

public class ResponseDTO<T>
{
    public T? Resutado { get; set; }
    public bool EsCorrecto { get; set; }
    public string? Mensaje { get; set; }
}
