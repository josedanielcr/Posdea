import { UserInternal } from "../interfaces/models/user.internal";
import { User } from "../models/user.model";
import { adaptAddress } from "./address.adapter";
import { adaptRole } from "./role.adapter";

export const adaptUser = (userInternal : UserInternal) : User => {
  let user = new User();
  user.id = userInternal.id;
  user.name = userInternal.name;
  user.email = userInternal.email;
  user.phoneNumber = userInternal.phoneNumber;
  user.password = userInternal.password;
  user.status = userInternal.status;
  user.address = adaptAddress(userInternal.address);
  user.addressId = userInternal.addressId;
  user.role = adaptRole(userInternal.role);
  user.roleId = userInternal.roleId;
  return user;
}