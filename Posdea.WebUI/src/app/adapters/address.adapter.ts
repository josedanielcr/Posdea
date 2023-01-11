import { AddressInternal } from "../interfaces/models/address.internal";
import { Address } from "../models/address.model";

export const adaptAddress = (addressInternal : AddressInternal) : Address => {
  let address = new Address();
  address.country = addressInternal.country;
  return address;
}