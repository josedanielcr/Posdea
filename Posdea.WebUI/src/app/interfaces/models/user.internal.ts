import { AddressInternal } from "./address.internal";
import { RoleInternal } from "./role.internal";

export interface UserInternal {
  id : number;
  name : string;
  email : string;
  phoneNumber : string;
  password : string;
  status : string;
  address : AddressInternal;
  addressId : number;
  role : RoleInternal;
  roleId : number;
}