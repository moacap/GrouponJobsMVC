//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace GrouponJobsMVC.DAL
{
    public partial class aspnet_Users
    {
        #region Primitive Properties
    
        public virtual System.Guid ApplicationId
        {
            get { return _applicationId; }
            set
            {
                if (_applicationId != value)
                {
                    if (aspnet_Applications != null && aspnet_Applications.ApplicationId != value)
                    {
                        aspnet_Applications = null;
                    }
                    _applicationId = value;
                }
            }
        }
        private System.Guid _applicationId;
    
        public virtual System.Guid UserId
        {
            get;
            set;
        }
    
        public virtual string UserName
        {
            get;
            set;
        }
    
        public virtual string LoweredUserName
        {
            get;
            set;
        }
    
        public virtual string MobileAlias
        {
            get;
            set;
        }
    
        public virtual bool IsAnonymous
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastActivityDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual aspnet_Applications aspnet_Applications
        {
            get { return _aspnet_Applications; }
            set
            {
                if (!ReferenceEquals(_aspnet_Applications, value))
                {
                    var previousValue = _aspnet_Applications;
                    _aspnet_Applications = value;
                    Fixupaspnet_Applications(previousValue);
                }
            }
        }
        private aspnet_Applications _aspnet_Applications;
    
        public virtual aspnet_Membership aspnet_Membership
        {
            get { return _aspnet_Membership; }
            set
            {
                if (!ReferenceEquals(_aspnet_Membership, value))
                {
                    var previousValue = _aspnet_Membership;
                    _aspnet_Membership = value;
                    Fixupaspnet_Membership(previousValue);
                }
            }
        }
        private aspnet_Membership _aspnet_Membership;
    
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser
        {
            get
            {
                if (_aspnet_PersonalizationPerUser == null)
                {
                    var newCollection = new FixupCollection<aspnet_PersonalizationPerUser>();
                    newCollection.CollectionChanged += Fixupaspnet_PersonalizationPerUser;
                    _aspnet_PersonalizationPerUser = newCollection;
                }
                return _aspnet_PersonalizationPerUser;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_PersonalizationPerUser, value))
                {
                    var previousValue = _aspnet_PersonalizationPerUser as FixupCollection<aspnet_PersonalizationPerUser>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_PersonalizationPerUser;
                    }
                    _aspnet_PersonalizationPerUser = value;
                    var newValue = value as FixupCollection<aspnet_PersonalizationPerUser>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_PersonalizationPerUser;
                    }
                }
            }
        }
        private ICollection<aspnet_PersonalizationPerUser> _aspnet_PersonalizationPerUser;
    
        public virtual aspnet_Profile aspnet_Profile
        {
            get { return _aspnet_Profile; }
            set
            {
                if (!ReferenceEquals(_aspnet_Profile, value))
                {
                    var previousValue = _aspnet_Profile;
                    _aspnet_Profile = value;
                    Fixupaspnet_Profile(previousValue);
                }
            }
        }
        private aspnet_Profile _aspnet_Profile;
    
        public virtual ICollection<aspnet_Roles> aspnet_Roles
        {
            get
            {
                if (_aspnet_Roles == null)
                {
                    var newCollection = new FixupCollection<aspnet_Roles>();
                    newCollection.CollectionChanged += Fixupaspnet_Roles;
                    _aspnet_Roles = newCollection;
                }
                return _aspnet_Roles;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_Roles, value))
                {
                    var previousValue = _aspnet_Roles as FixupCollection<aspnet_Roles>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_Roles;
                    }
                    _aspnet_Roles = value;
                    var newValue = value as FixupCollection<aspnet_Roles>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_Roles;
                    }
                }
            }
        }
        private ICollection<aspnet_Roles> _aspnet_Roles;

        #endregion
        #region Association Fixup
    
        private void Fixupaspnet_Applications(aspnet_Applications previousValue)
        {
            if (previousValue != null && previousValue.aspnet_Users.Contains(this))
            {
                previousValue.aspnet_Users.Remove(this);
            }
    
            if (aspnet_Applications != null)
            {
                if (!aspnet_Applications.aspnet_Users.Contains(this))
                {
                    aspnet_Applications.aspnet_Users.Add(this);
                }
                if (ApplicationId != aspnet_Applications.ApplicationId)
                {
                    ApplicationId = aspnet_Applications.ApplicationId;
                }
            }
        }
    
        private void Fixupaspnet_Membership(aspnet_Membership previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.aspnet_Users, this))
            {
                previousValue.aspnet_Users = null;
            }
    
            if (aspnet_Membership != null)
            {
                aspnet_Membership.aspnet_Users = this;
            }
        }
    
        private void Fixupaspnet_Profile(aspnet_Profile previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.aspnet_Users, this))
            {
                previousValue.aspnet_Users = null;
            }
    
            if (aspnet_Profile != null)
            {
                aspnet_Profile.aspnet_Users = this;
            }
        }
    
        private void Fixupaspnet_PersonalizationPerUser(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_PersonalizationPerUser item in e.NewItems)
                {
                    item.aspnet_Users = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_PersonalizationPerUser item in e.OldItems)
                {
                    if (ReferenceEquals(item.aspnet_Users, this))
                    {
                        item.aspnet_Users = null;
                    }
                }
            }
        }
    
        private void Fixupaspnet_Roles(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_Roles item in e.NewItems)
                {
                    if (!item.aspnet_Users.Contains(this))
                    {
                        item.aspnet_Users.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_Roles item in e.OldItems)
                {
                    if (item.aspnet_Users.Contains(this))
                    {
                        item.aspnet_Users.Remove(this);
                    }
                }
            }
        }

        #endregion
    }
}
