// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System.Security.Claims
{
    public partial class Claim
    {
        public Claim(System.IO.BinaryReader reader) { }
        public Claim(System.IO.BinaryReader reader, System.Security.Claims.ClaimsIdentity subject) { }
        protected Claim(System.Security.Claims.Claim other) { }
        protected Claim(System.Security.Claims.Claim other, System.Security.Claims.ClaimsIdentity subject) { }
        public Claim(string type, string value) { }
        public Claim(string type, string value, string valueType) { }
        public Claim(string type, string value, string valueType, string issuer) { }
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer) { }
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer, System.Security.Claims.ClaimsIdentity subject) { }
        protected virtual byte[] CustomSerializationData { get { return default(byte[]); } }
        public string Issuer { get { return default(string); } }
        public string OriginalIssuer { get { return default(string); } }
        public System.Collections.Generic.IDictionary<string, string> Properties { get { return default(System.Collections.Generic.IDictionary<string, string>); } }
        public System.Security.Claims.ClaimsIdentity Subject { get { return default(System.Security.Claims.ClaimsIdentity); } }
        public string Type { get { return default(string); } }
        public string Value { get { return default(string); } }
        public string ValueType { get { return default(string); } }
        public virtual System.Security.Claims.Claim Clone() { return default(System.Security.Claims.Claim); }
        public virtual System.Security.Claims.Claim Clone(System.Security.Claims.ClaimsIdentity identity) { return default(System.Security.Claims.Claim); }
        public override string ToString() { return default(string); }
        public virtual void WriteTo(System.IO.BinaryWriter writer) { }
        protected virtual void WriteTo(System.IO.BinaryWriter writer, byte[] userData) { }
    }
    public partial class ClaimsIdentity : System.Security.Principal.IIdentity
    {
        public const string DefaultIssuer = "LOCAL AUTHORITY";
        public const string DefaultNameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
        public const string DefaultRoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
        public ClaimsIdentity() { }
        public ClaimsIdentity(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims) { }
        public ClaimsIdentity(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims, string authenticationType) { }
        public ClaimsIdentity(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims, string authenticationType, string nameType, string roleType) { }
        public ClaimsIdentity(System.IO.BinaryReader reader) { }
        protected ClaimsIdentity(System.Security.Claims.ClaimsIdentity other) { }
        public ClaimsIdentity(System.Security.Principal.IIdentity identity) { }
        public ClaimsIdentity(System.Security.Principal.IIdentity identity, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims) { }
        public ClaimsIdentity(System.Security.Principal.IIdentity identity, System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims, string authenticationType, string nameType, string roleType) { }
        public ClaimsIdentity(string authenticationType) { }
        public ClaimsIdentity(string authenticationType, string nameType, string roleType) { }
        public System.Security.Claims.ClaimsIdentity Actor { get { return default(System.Security.Claims.ClaimsIdentity); } set { } }
        public virtual string AuthenticationType { get { return default(string); } }
        public object BootstrapContext { get { return default(object); }[System.Security.SecurityCriticalAttribute]set { } }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> Claims { get { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); } }
        protected virtual byte[] CustomSerializationData { get { return default(byte[]); } }
        public virtual bool IsAuthenticated { get { return default(bool); } }
        public string Label { get { return default(string); } set { } }
        public virtual string Name { get { return default(string); } }
        public string NameClaimType { get { return default(string); } }
        public string RoleClaimType { get { return default(string); } }
        [System.Security.SecurityCriticalAttribute]
        public virtual void AddClaim(System.Security.Claims.Claim claim) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual void AddClaims(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> claims) { }
        public virtual System.Security.Claims.ClaimsIdentity Clone() { return default(System.Security.Claims.ClaimsIdentity); }
        protected virtual System.Security.Claims.Claim CreateClaim(System.IO.BinaryReader reader) { return default(System.Security.Claims.Claim); }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> FindAll(System.Predicate<System.Security.Claims.Claim> match) { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> FindAll(string type) { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); }
        public virtual System.Security.Claims.Claim FindFirst(System.Predicate<System.Security.Claims.Claim> match) { return default(System.Security.Claims.Claim); }
        public virtual System.Security.Claims.Claim FindFirst(string type) { return default(System.Security.Claims.Claim); }
        public virtual bool HasClaim(System.Predicate<System.Security.Claims.Claim> match) { return default(bool); }
        public virtual bool HasClaim(string type, string value) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public virtual void RemoveClaim(System.Security.Claims.Claim claim) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual bool TryRemoveClaim(System.Security.Claims.Claim claim) { return default(bool); }
        public virtual void WriteTo(System.IO.BinaryWriter writer) { }
        protected virtual void WriteTo(System.IO.BinaryWriter writer, byte[] userData) { }
    }
    public partial class ClaimsPrincipal : System.Security.Principal.IPrincipal
    {
        public ClaimsPrincipal() { }
        public ClaimsPrincipal(System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity> identities) { }
        public ClaimsPrincipal(System.IO.BinaryReader reader) { }
        public ClaimsPrincipal(System.Security.Principal.IIdentity identity) { }
        public ClaimsPrincipal(System.Security.Principal.IPrincipal principal) { }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> Claims { get { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); } }
        public static System.Func<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalSelector { get { return default(System.Func<System.Security.Claims.ClaimsPrincipal>); }[System.Security.SecurityCriticalAttribute]set { } }
        public static System.Security.Claims.ClaimsPrincipal Current { get { return default(System.Security.Claims.ClaimsPrincipal); } }
        protected virtual byte[] CustomSerializationData { get { return default(byte[]); } }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity> Identities { get { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>); } }
        public virtual System.Security.Principal.IIdentity Identity { get { return default(System.Security.Principal.IIdentity); } }
        public static System.Func<System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>, System.Security.Claims.ClaimsIdentity> PrimaryIdentitySelector { get { return default(System.Func<System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>, System.Security.Claims.ClaimsIdentity>); }[System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecurityCriticalAttribute]
        public virtual void AddIdentities(System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity> identities) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual void AddIdentity(System.Security.Claims.ClaimsIdentity identity) { }
        public virtual System.Security.Claims.ClaimsPrincipal Clone() { return default(System.Security.Claims.ClaimsPrincipal); }
        protected virtual System.Security.Claims.ClaimsIdentity CreateClaimsIdentity(System.IO.BinaryReader reader) { return default(System.Security.Claims.ClaimsIdentity); }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> FindAll(System.Predicate<System.Security.Claims.Claim> match) { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); }
        public virtual System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> FindAll(string type) { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); }
        public virtual System.Security.Claims.Claim FindFirst(System.Predicate<System.Security.Claims.Claim> match) { return default(System.Security.Claims.Claim); }
        public virtual System.Security.Claims.Claim FindFirst(string type) { return default(System.Security.Claims.Claim); }
        public virtual bool HasClaim(System.Predicate<System.Security.Claims.Claim> match) { return default(bool); }
        public virtual bool HasClaim(string type, string value) { return default(bool); }
        public virtual bool IsInRole(string role) { return default(bool); }
        public virtual void WriteTo(System.IO.BinaryWriter writer) { }
        protected virtual void WriteTo(System.IO.BinaryWriter writer, byte[] userData) { }
    }
    public static partial class ClaimTypes
    {
        public const string Actor = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor";
        public const string Anonymous = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous";
        public const string Authentication = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authentication";
        public const string AuthenticationInstant = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant";
        public const string AuthenticationMethod = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod";
        public const string AuthorizationDecision = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision";
        public const string CookiePath = "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath";
        public const string Country = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country";
        public const string DateOfBirth = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth";
        public const string DenyOnlyPrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid";
        public const string DenyOnlyPrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid";
        public const string DenyOnlySid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid";
        public const string DenyOnlyWindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup";
        public const string Dns = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns";
        public const string Dsa = "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa";
        public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        public const string Expiration = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration";
        public const string Expired = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired";
        public const string Gender = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender";
        public const string GivenName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname";
        public const string GroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid";
        public const string Hash = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash";
        public const string HomePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone";
        public const string IsPersistent = "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent";
        public const string Locality = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality";
        public const string MobilePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone";
        public const string Name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
        public const string NameIdentifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";
        public const string OtherPhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone";
        public const string PostalCode = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode";
        public const string PrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid";
        public const string PrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid";
        public const string Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
        public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa";
        public const string SerialNumber = "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber";
        public const string Sid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid";
        public const string Spn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn";
        public const string StateOrProvince = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince";
        public const string StreetAddress = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress";
        public const string Surname = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname";
        public const string System = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system";
        public const string Thumbprint = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint";
        public const string Upn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn";
        public const string Uri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri";
        public const string UserData = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata";
        public const string Version = "http://schemas.microsoft.com/ws/2008/06/identity/claims/version";
        public const string Webpage = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage";
        public const string WindowsAccountName = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname";
        public const string WindowsDeviceClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim";
        public const string WindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup";
        public const string WindowsFqbnVersion = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion";
        public const string WindowsSubAuthority = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority";
        public const string WindowsUserClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim";
        public const string X500DistinguishedName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname";
    }
    public static partial class ClaimValueTypes
    {
        public const string Base64Binary = "http://www.w3.org/2001/XMLSchema#base64Binary";
        public const string Base64Octet = "http://www.w3.org/2001/XMLSchema#base64Octet";
        public const string Boolean = "http://www.w3.org/2001/XMLSchema#boolean";
        public const string Date = "http://www.w3.org/2001/XMLSchema#date";
        public const string DateTime = "http://www.w3.org/2001/XMLSchema#dateTime";
        public const string DaytimeDuration = "http://www.w3.org/TR/2002/WD-xquery-operators-20020816#dayTimeDuration";
        public const string DnsName = "http://schemas.xmlsoap.org/claims/dns";
        public const string Double = "http://www.w3.org/2001/XMLSchema#double";
        public const string DsaKeyValue = "http://www.w3.org/2000/09/xmldsig#DSAKeyValue";
        public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        public const string Fqbn = "http://www.w3.org/2001/XMLSchema#fqbn";
        public const string HexBinary = "http://www.w3.org/2001/XMLSchema#hexBinary";
        public const string Integer = "http://www.w3.org/2001/XMLSchema#integer";
        public const string Integer32 = "http://www.w3.org/2001/XMLSchema#integer32";
        public const string Integer64 = "http://www.w3.org/2001/XMLSchema#integer64";
        public const string KeyInfo = "http://www.w3.org/2000/09/xmldsig#KeyInfo";
        public const string Rfc822Name = "urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name";
        public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa";
        public const string RsaKeyValue = "http://www.w3.org/2000/09/xmldsig#RSAKeyValue";
        public const string Sid = "http://www.w3.org/2001/XMLSchema#sid";
        public const string String = "http://www.w3.org/2001/XMLSchema#string";
        public const string Time = "http://www.w3.org/2001/XMLSchema#time";
        public const string UInteger32 = "http://www.w3.org/2001/XMLSchema#uinteger32";
        public const string UInteger64 = "http://www.w3.org/2001/XMLSchema#uinteger64";
        public const string UpnName = "http://schemas.xmlsoap.org/claims/UPN";
        public const string X500Name = "urn:oasis:names:tc:xacml:1.0:data-type:x500Name";
        public const string YearMonthDuration = "http://www.w3.org/TR/2002/WD-xquery-operators-20020816#yearMonthDuration";
    }
}
namespace System.Security.Principal
{
    public partial class GenericIdentity : System.Security.Claims.ClaimsIdentity
    {
        protected GenericIdentity(System.Security.Principal.GenericIdentity identity) { }
        public GenericIdentity(string name) { }
        public GenericIdentity(string name, string type) { }
        public override string AuthenticationType { get { return default(string); } }
        public override System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> Claims { get { return default(System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>); } }
        public override bool IsAuthenticated { get { return default(bool); } }
        public override string Name { get { return default(string); } }
        public override System.Security.Claims.ClaimsIdentity Clone() { return default(System.Security.Claims.ClaimsIdentity); }
    }
    public partial class GenericPrincipal : System.Security.Claims.ClaimsPrincipal
    {
        public GenericPrincipal(System.Security.Principal.IIdentity identity, string[] roles) { }
        public override System.Security.Principal.IIdentity Identity { get { return default(System.Security.Principal.IIdentity); } }
        public override bool IsInRole(string role) { return default(bool); }
    }
}
