//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v10.7.2.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------







export interface UserRole {
    userId: number;
    loginName: string | undefined;
    userName: string | undefined;
    userMail: string | undefined;
    roleId: RoleId;
}

export enum RoleId {
    Initiator = 1,
    Advisor = 2,
    DecisionMaker = 3,
    Oec = 4,
    SupportGroup = 5,
    Viewer = 6,
    System = 7,
    AreaFunctionalAdmin = 8,
    AreaSecurityAdmin = 9,
    CountryFunctionalAdmin = 10,
    CountrySecurityAdmin = 11,
    GlobalFunctionalAdmin = 12,
    GlobalSecurityAdmin = 13,
    Notifier = 14,
    SecondAdvisor = 15,
    BusinessSupport = 16,
    Validator = 17,
    OecPlus = 18,
    Legal = 19,
    CountrySecurityLead = 20,
    PlaneaBusinessPlansUser = 21,
    PlaneaFinancialPlanning = 22,
    PlaneaConsultation = 23,
    PlaneaAdministrator = 24,
    ProductOwner = 25,
    CrossBorderAdmin = 26,
}

export interface User {
    userId: number;
    userName: string | undefined;
    userMail: string | undefined;
    isActive: boolean;
    createdDate: Date;
    createdBy: number;
    modifiedDate: Date;
    modifiedBy: number;
    loginName: string | undefined;
    cultureCode: string | undefined;
    upi: string | undefined;
    ouId: number;
    title: string | undefined;
    seeCompactView: boolean;
    loginFailedAttemptsCount: number;
    lastLoginAttempt: Date | undefined;
    hideAudit: boolean;
    division: string | undefined;
    token: string | undefined;
    roles: UserRole[] | undefined;
}