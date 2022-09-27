//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v10.7.2.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------







export enum EntityTypeId {
    Application = 1,
    User = 2,
    Role = 3,
    Permission = 4,
    RolePermission = 5,
    UserRoleEntity = 6,
    UserRole = 7,
    UserPermission = 8,
    Entity = 9,
    EntityAncestors = 10,
    EntityType = 11,
    OrganizationalUnit = 12,
    FileContent = 13,
    FormInstanceFile = 14,
    MapForm = 15,
    ReferenceDataEtag = 16,
    LocalizableText = 17,
    Text = 18,
    MapPhase = 19,
    MapSection = 20,
    MapFormSection = 21,
    MapFormSectionField = 22,
    FormInstance = 23,
    Products = 24,
    MapFormInstanceStatus = 33,
    FormInstanceStatus = 34,
    ItemType = 35,
    ReferenceTableItem = 36,
    ReferenceTableItemType = 37,
    ActivityMenu = 38,
    SupportedCultures = 39,
    SupportedCulture = 40,
    FormInstanceSearchItem = 41,
    StateMachineTransition = 42,
    OuFigure = 43,
    Figure = 44,
    AppEmail = 45,
    EmailAttachment = 46,
    EmailStatus = 47,
    AppEmailAttachment = 48,
    ProcessHistoryEntry = 49,
    Accommodation = 51,
    ProfessionalService = 52,
    Material = 53,
    RecipientDetail = 54,
    CostReconciliation = 55,
    MapFormOrganizationalUnit = 56,
    MapFormCategory = 57,
    FormFileType = 58,
    MapFormFile = 59,
    FormInstanceFileVersion = 60,
    Delegation = 63,
    MapFormCheck = 64,
    FormInstanceCheck = 65,
    MapCheck = 66,
    AuditEntry = 67,
    DelegationStatuses = 68,
    AuditEntries = 69,
    ViewedFileContent = 70,
    Currency = 71,
    OrganizationalUnitExchangeRate = 72,
    SponsorshipOther = 73,
    FormInstanceLastHistoryEntry = 74,
    MapFormGroup = 75,
    FormInstanceIncident = 76,
    FormInstanceJustification = 78,
    OrganizationalUnitType = 79,
    Currencies = 80,
    Config = 81,
    Event = 82,
    Consultant = 83,
    Organization = 84,
    ConsultantOrganization = 85,
    Customer = 86,
    CustomerRelationship = 87,
    ProfessionalServicesAudit = 88,
    ProfessionalSservicesAudit = 89,
    MaterialAudit = 90,
    AccommodationAudit = 91,
    ProfessionalServiceAudit = 92,
    SponsorshipOtherAudit = 93,
    CustomersCustomerSubTypes = 94,
    CustomersCustomerSubType = 95,
    ReferenceTableItemMapForm = 96,
    CostReconciliationPayments = 97,
    FormInstanceAttendeesOther = 98,
    Comment = 99,
    FormInstanceContributionCostOther = 100,
    DonationItem = 101,
    DonationCost = 102,
    FormInstanceAttendeesAssistant = 103,
    Schedule = 104,
    CostReconciliationCostCenters = 105,
    CostReconciliationInternalOrderNumbers = 106,
    FormInstanceIcb = 107,
    IcbCostReconciliation = 108,
    ThirdPartyLogisticsVendor = 109,
    PatientOrganization = 110,
    IcbCostReconciliationPayments = 111,
    IcbCostReconciliationInternalOrderNumbers = 112,
    IcbCostReconciliationCostCenters = 113,
    Contract = 114,
    ContractComment = 115,
    FormInstanceInvoice = 116,
    FormInstanceInvoiceComment = 117,
    FormInstanceInvoiceLine = 118,
    CostCenterTeam = 119,
    ProjectBackgroundActivities = 200,
    LogisticalArrangementExtended = 278,
    Milestone = 287,
    FormInstanceRequest = 288,
    FormInstanceBusinessPlanRelationship = 296,
}

export interface Entity {
    entityId: number;
    entityTypeId: EntityTypeId;
    parentEntityId: number | undefined;
}