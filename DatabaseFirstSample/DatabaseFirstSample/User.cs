//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {

        }
        public User(string mail)
        {
            //this.reminders = new HashSet<reminder>();
            //this.UserInGroups = new HashSet<UserInGroup>();
            //this.chatItems = new HashSet<chatItem>();
            this.mail = mail;
            //this.UserInGroups = new HashSet<UserInGroup>();
        }
        public User(
           string mail,
           string firstName,
           string lastName,
           byte[] profile,
           string password,
           string city,
           string streat
           )
        {
            this.mail = mail;
            this.firstName = firstName;
            this.lastName = lastName;
            this.profile_ = profile;
            this.password_ = password;
            this.city = city;
            this.streat = streat;
            //this.reminders = new HashSet<reminder>();
            //this.UserInGroups = new HashSet<UserInGroup>();
            //this.chatItems = new HashSet<chatItem>();
            //this.UserInGroups = new HashSet<UserInGroup>();
        }
        public User(
           string mail,
           string firstName,
           string lastName,
           byte[] profile,
           string password,
           string city,
           string streat,
           int build,
           string phone
           )
        {
            this.mail = mail;
            this.firstName = firstName;
            this.lastName = lastName;
            this.profile_ = profile;
            this.password_ = password;
            this.city = city;
            this.streat = streat;
            this.build = build;
            //this.reminders = new HashSet<reminder>();
            //this.UserInGroups = new HashSet<UserInGroup>();
            //this.chatItems = new HashSet<chatItem>();
            //this.UserInGroups = new HashSet<UserInGroup>();
        }
        [DataMember]
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataMember]
        public byte[] profile_ { get; set; }
        [DataMember]
        public string mail { get; set; }
        [DataMember]
        public string password_ { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string streat { get; set; }
        [DataMember]
        public Nullable<int> build { get; set; }
        [DataMember]
        public Nullable<double> latitute { get; set; }
        [DataMember]
        public Nullable<double> longitude { get; set; }
        [DataMember]
        public virtual AdministratorSetting AdministratorSetting { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reminder> reminders { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
        [DataMember]
        public virtual responseImage responseImage { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chatItem> chatItems { get; set; }
    }
}
