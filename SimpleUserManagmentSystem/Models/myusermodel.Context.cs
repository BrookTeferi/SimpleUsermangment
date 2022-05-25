﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleUserManagmentSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class userEntities : DbContext
    {
        public userEntities()
            : base("name=userEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual int firstname_Search(string firstname)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("firstname_Search", firstnameParameter);
        }
    
        public virtual ObjectResult<USER> Fun_firstname_Search(string firstname)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("Fun_firstname_Search", firstnameParameter);
        }
    
        public virtual ObjectResult<USER> Fun_firstname_Search(string firstname, MergeOption mergeOption)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("Fun_firstname_Search", mergeOption, firstnameParameter);
        }
    
        public virtual int dispalyalluser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dispalyalluser");
        }
    
        public virtual int dispalyallusers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dispalyallusers");
        }
    
        public virtual ObjectResult<USER> displayallusers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("displayallusers");
        }
    
        public virtual ObjectResult<USER> displayallusers(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("displayallusers", mergeOption);
        }
    
        public virtual int allusers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("allusers");
        }
    
        public virtual int GetUser(string firstname)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetUser", firstnameParameter);
        }
    
        public virtual ObjectResult<USER> A(string firstname)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("A", firstnameParameter);
        }
    
        public virtual ObjectResult<USER> A(string firstname, MergeOption mergeOption)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("A", mergeOption, firstnameParameter);
        }
    
        public virtual int Usp_Usersearch(string nameer)
        {
            var nameerParameter = nameer != null ?
                new ObjectParameter("nameer", nameer) :
                new ObjectParameter("nameer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Usersearch", nameerParameter);
        }
    
        public virtual ObjectResult<USER> Getcolumninformation(string nameer)
        {
            var nameerParameter = nameer != null ?
                new ObjectParameter("nameer", nameer) :
                new ObjectParameter("nameer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("Getcolumninformation", nameerParameter);
        }
    
        public virtual ObjectResult<USER> Getcolumninformation(string nameer, MergeOption mergeOption)
        {
            var nameerParameter = nameer != null ?
                new ObjectParameter("nameer", nameer) :
                new ObjectParameter("nameer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("Getcolumninformation", mergeOption, nameerParameter);
        }
    
        public virtual int Usp_Usersearch1(string nameer)
        {
            var nameerParameter = nameer != null ?
                new ObjectParameter("nameer", nameer) :
                new ObjectParameter("nameer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_Usersearch1", nameerParameter);
        }
    }
}
