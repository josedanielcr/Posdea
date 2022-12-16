import { RoleInternal } from "../interfaces/models/role.internal";
import { Role } from "../models/role.model";
import { adaptMenuOptions } from "./menuOption.adapter";

export const adaptRole = (roleInternal : RoleInternal) : Role => {
  if(!roleInternal) {
    return new Role();
  }
  let role = new Role();
  role.name = roleInternal.name;
  role.status = roleInternal.status;
  role.menuOptions = adaptMenuOptions(roleInternal.menuOptions);
  return role;
}