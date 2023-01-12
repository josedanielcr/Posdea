import { Address } from "./address.model";
import { Role } from "./role.model";

export class User {
  public id! : number;
  public name! : string;
  public email! : string;
  public avatar! : string;
  public phoneNumber! : string;
  public password! : string;
  public status! : string;
  public address! : Address;
  public addressId! : number;
  public role! : Role;
  public roleId! : number;

  constructor(){}
}