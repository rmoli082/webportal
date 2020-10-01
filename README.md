# MorashPortal Enterprise Web Portal
MorashPortal Enterprise Web Portal is a simple enterprise web portal. It is based on a microservices architecture and features the following services:

## MorashPortal
#### Simple ASP.NET Core WebApp
MorashPortal is the graphical frontend to the MorashPortal Enterprise Web Portal software suite. MorashPortal provides access to all the provided services using a simple, clean, responsive design. 

MorashPortal is an MVC WebApp that was created in ASP.NET Core 3.1

## TimeCard
#### Simple ASP.NET Core Web API service
TimeCard is the first microservice created for MorashPortal. TimeCard currently allows you to create a new time card, get a time card by ID, get time cards by employee number, and delete records.

TimeCard uses C#, .NET Core 3.1, EntityFrameworkCore and an Azure hosted SQL Database to provide the functionality for the service.
