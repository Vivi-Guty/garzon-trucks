import { OrganizationalUnitType } from "./OrganizationalUnitType";
import { Role } from "./Role";


export interface OrganizationalUnitTypeModel extends OrganizationalUnitType {
  Roles: Role[];
}
