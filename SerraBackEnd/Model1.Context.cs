﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerraBackEnd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PracticaSerraUpdateEntities : DbContext
    {
        public PracticaSerraUpdateEntities()
            : base("name=PracticaSerraUpdateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int AddUtilizator(string newUsername, string newPassword, string newNume, string newPrenume, string newEmail, Nullable<decimal> newTelephone, Nullable<int> newUserID)
        {
            var newUsernameParameter = newUsername != null ?
                new ObjectParameter("NewUsername", newUsername) :
                new ObjectParameter("NewUsername", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            var newNumeParameter = newNume != null ?
                new ObjectParameter("NewNume", newNume) :
                new ObjectParameter("NewNume", typeof(string));
    
            var newPrenumeParameter = newPrenume != null ?
                new ObjectParameter("NewPrenume", newPrenume) :
                new ObjectParameter("NewPrenume", typeof(string));
    
            var newEmailParameter = newEmail != null ?
                new ObjectParameter("NewEmail", newEmail) :
                new ObjectParameter("NewEmail", typeof(string));
    
            var newTelephoneParameter = newTelephone.HasValue ?
                new ObjectParameter("NewTelephone", newTelephone) :
                new ObjectParameter("NewTelephone", typeof(decimal));
    
            var newUserIDParameter = newUserID.HasValue ?
                new ObjectParameter("NewUserID", newUserID) :
                new ObjectParameter("NewUserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUtilizator", newUsernameParameter, newPasswordParameter, newNumeParameter, newPrenumeParameter, newEmailParameter, newTelephoneParameter, newUserIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> AverageQuantity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("AverageQuantity");
        }
    
        public virtual ObjectResult<Nullable<decimal>> BiggestQuantity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("BiggestQuantity");
        }
    
        public virtual int DeleteUtilizatori(Nullable<int> idDeletedUser)
        {
            var idDeletedUserParameter = idDeletedUser.HasValue ?
                new ObjectParameter("IdDeletedUser", idDeletedUser) :
                new ObjectParameter("IdDeletedUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUtilizatori", idDeletedUserParameter);
        }
    
        public virtual ObjectResult<GetAllPlantations_Result> GetAllPlantations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPlantations_Result>("GetAllPlantations");
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<GetAllWorkers_Result> GetAllWorkers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllWorkers_Result>("GetAllWorkers");
        }
    
        public virtual ObjectResult<GetAllWorkersWithFields_Result> GetAllWorkersWithFields(string newValue)
        {
            var newValueParameter = newValue != null ?
                new ObjectParameter("NewValue", newValue) :
                new ObjectParameter("NewValue", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllWorkersWithFields_Result>("GetAllWorkersWithFields", newValueParameter);
        }
    
        public virtual ObjectResult<MostProductiveWorker_Result> MostProductiveWorker()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostProductiveWorker_Result>("MostProductiveWorker");
        }
    
        public virtual ObjectResult<Nullable<int>> NumberOfProductiveWorkers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("NumberOfProductiveWorkers");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalQuantity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalQuantity");
        }
    
        public virtual int UpdateUtilizator(Nullable<int> utilizatorID, string nume, string prenume, string email, Nullable<decimal> telefon)
        {
            var utilizatorIDParameter = utilizatorID.HasValue ?
                new ObjectParameter("UtilizatorID", utilizatorID) :
                new ObjectParameter("UtilizatorID", typeof(int));
    
            var numeParameter = nume != null ?
                new ObjectParameter("Nume", nume) :
                new ObjectParameter("Nume", typeof(string));
    
            var prenumeParameter = prenume != null ?
                new ObjectParameter("Prenume", prenume) :
                new ObjectParameter("Prenume", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon.HasValue ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUtilizator", utilizatorIDParameter, numeParameter, prenumeParameter, emailParameter, telefonParameter);
        }
    }
}
