using ClassLibraryForTCPConnectionAPI_C_sharp_;
using DatabaseEntities;
using System.Collections.Generic;
using System.Linq;

namespace TCPConnectionAPIClientModule_C_sharp_
{
    public class ClientConnectionModule : IAdminAccess, IExpertAccess, IClientAccess
    {
        protected IUserProtocol protocol;

        protected static int amountOfObjects;

        public bool Connected { get; }

        public ClientConnectionModule()
        {
            protocol = new TCPClientProtocol();
            if (amountOfObjects == 0)
            {
                Connected = protocol.Connect();
            }
            amountOfObjects++;
        }

        public TypeOfUser Authorization(string login, string password)
        {
            protocol.SendCommand(CommandsToServer.Authorization);
            protocol.SendLogin(login);
            protocol.SendPassword(password);
            return protocol.ReceiveTypeOfUser();
        }

        public AnswerFromServer Registration<T>(TypeOfUser type, T user) where T : class
        {
            protocol.SendCommand(CommandsToServer.Registration);
            protocol.SendTypeOfUser(type);
            protocol.SendObject<T>(user);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer Rate(int entityId, float Rate)
        {
            protocol.SendCommand(CommandsToServer.RateSubcontractor);
            protocol.SendString(entityId.ToString());
            protocol.SendString(Rate.ToString());
            return protocol.ReceiveAnswerFromServer();
        }

        public void PreviousRoom()
        {
            protocol.GoToPreviousRoom();
        }

        public Client FindClientByLogin(string login)
        {
            protocol.SendCommand(CommandsToServer.FindClientByLogin);
            protocol.SendLogin(login);
            var received = protocol.ReceiveCollection<Client>();
            if (received.Count == 0 || received.Count > 1)
            {
                return new Client();
            }
            else
            {
                return received.First();
            }
        }

        public Expert FindExpertByLogin(string login)
        {
            protocol.SendCommand(CommandsToServer.FindExpertByLogin);
            protocol.SendLogin(login);
            var received = protocol.ReceiveCollection<Expert>();
            if (received.Count == 0 || received.Count > 1)
            {
                return new Expert();
            }
            else
            {
                return received.First();
            }
        }

        public Admin FindAdminByLogin(string login)
        {
            protocol.SendCommand(CommandsToServer.FindAdminByLogin);
            protocol.SendLogin(login);
            var received = protocol.ReceiveCollection<Admin>();
            if (received.Count == 0 || received.Count > 1)
            {
                return new Admin();
            }
            else
            {
                return received.First();
            }
        }

        public AnswerFromServer RegisterNewAdmin(Admin admin)
        {
            protocol.SendCommand(CommandsToServer.RegisterNewAdmin);
            protocol.SendObject(admin);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer RegisterNewClient(Client client)
        {
            protocol.SendCommand(CommandsToServer.RegisterNewClient);
            protocol.SendObject(client);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer RegisterNewExpert(Expert expert)
        {
            protocol.SendCommand(CommandsToServer.RegisterNewExpert);
            protocol.SendObject(expert);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer BanClientWith(string login)
        {
            protocol.SendCommand(CommandsToServer.BanClient);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer BanExpertWith(string login)
        {
            protocol.SendCommand(CommandsToServer.BanExpert);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer UnbanExpertWith(string login)
        {
            protocol.SendCommand(CommandsToServer.UnbanExpert);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer UnbanClientWith(string login)
        {
            protocol.SendCommand(CommandsToServer.UnbanExpert);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer DeleteExpertWith(string login)
        {
            protocol.SendCommand(CommandsToServer.DeleteExpert);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer DeleteClientWith(string login)
        {
            protocol.SendCommand(CommandsToServer.DeleteClient);
            protocol.SendLogin(login);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer CreateSubcontractor(Subcontractor obj)
        {
            protocol.SendCommand(CommandsToServer.CreateSubcontractor);
            protocol.SendObject(obj);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer ModifySubcontractor(Subcontractor newVersion)
        {
            protocol.SendCommand(CommandsToServer.ModifySubcontractor);
            protocol.SendObject(newVersion);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer DeleteSubcontractor(int id)
        {
            protocol.SendCommand(CommandsToServer.DeleteSubcontractor);
            protocol.SendString(id.ToString());
            return protocol.ReceiveAnswerFromServer();
        }

        public string GetReportAboutSubconstructors()
        {
            protocol.SendCommand(CommandsToServer.CreateReportAboutSubcontractor);
            return protocol.ReceiveString();
        }

        public List<Client> GetAllClients()
        {
            protocol.SendCommand(CommandsToServer.GetAllClients);
            return protocol.ReceiveCollection<Client>();
        }

        public List<Expert> GetAllExperts()
        {
            protocol.SendCommand(CommandsToServer.GetAllExperts);
            return protocol.ReceiveCollection<Expert>();
        }

        public List<Subcontractor> GetAllSubcontactors()
        {
            protocol.SendCommand(CommandsToServer.GetAllSubcontractors);
            return protocol.ReceiveCollection<Subcontractor>();
        }

        public AnswerFromServer ModifyClient(Client client)
        {
            protocol.SendCommand(CommandsToServer.ModifyClient);
            protocol.SendObject(client);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer ModifyExpert(Expert expert)
        {
            protocol.SendCommand(CommandsToServer.ModifyExpert);
            protocol.SendObject(expert);
            return protocol.ReceiveAnswerFromServer();
        }

        public AnswerFromServer RateSubconstructor(int subconstructorId, float expertRate)
        {
            protocol.SendCommand(CommandsToServer.RateSubcontractor);
            protocol.SendString(subconstructorId.ToString());
            protocol.SendString(expertRate.ToString());
            return protocol.ReceiveAnswerFromServer();
        }

        public List<Subcontractor> FindSubcontractorWithName(string name)
        {
            protocol.SendCommand(CommandsToServer.FindSubcontractorsByName);
            protocol.SendString(name);
            return protocol.ReceiveCollection<Subcontractor>();
        }

        public List<Subcontractor> FindSubcontractorWithTotalRate(double rate)
        {
            protocol.SendCommand(CommandsToServer.FindSubcontractorsByRate);
            protocol.SendString(rate.ToString());
            return protocol.ReceiveCollection<Subcontractor>();
        }

        public List<Admin> GetAllAdmins()
        {
            protocol.SendCommand(CommandsToServer.GetAllAdmins);
            return protocol.ReceiveCollection<Admin>();
        }

        public List<Subcontractor> FindSubcontractorWithUNP(int unp)
        {
            protocol.SendCommand(CommandsToServer.FindSubcontractorsByUNP);
            protocol.SendString(unp.ToString());
            return protocol.ReceiveCollection<Subcontractor>();
        }

        public List<Subcontractor> FindSubcontractorWithAmountOfEmployees(int amount)
        {
            protocol.SendCommand(CommandsToServer.FindSubcontractorsByAmountOfEmployees);
            protocol.SendString(amount.ToString());
            return protocol.ReceiveCollection<Subcontractor>();
        }
    }
}
