﻿namespace ClassLibraryForTCPConnectionAPI_C_sharp_
{
    public enum CommandsToServer
    {
        Registration,
        Authorization,
        PreviousRoom,
        //Admin commands
        RegisterNewAdmin,
        RegisterNewClient,
        RegisterNewExpert,
        BanClient,
        BanExpert,
        UnbanClient,
        UnbanExpert,
        DeleteClient,
        DeleteExpert,
        ModifyClient,
        ModifyExpert,
        FindClientByLogin,
        GetAllClients,
        GetAllAdmins,
        FindExpertByLogin,
        GetAllExperts,
        FindAdminByLogin,
        CreateSubcontractor,
        ModifySubcontractor,
        DeleteSubcontractor,
        CreateReportAboutSubcontractor,
        //Expert commands
        RateSubcontractor, 
        //Client commands
        FindSubcontractorsByName,
        FindSubcontractorsByAmountOfEmployees,
        FindSubcontractorsByUNP,
        FindSubcontractorsByRate,
        GetAllSubcontractors,
        
    }
}
