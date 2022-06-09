using DatabaseEntities;

namespace TCPConnectionAPI_C_sharp_
{
    public interface IExpertAbilityProtocol : IClientAbilityProtocol
    {
        IExpertMethod expertMethod { get; set; }
        bool Rate(Subcontractor entity, Expert expert, float rate);
    }
}
