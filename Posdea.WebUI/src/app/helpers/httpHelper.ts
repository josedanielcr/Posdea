import { HttpErrorResponse } from "@angular/common/http";
import { ApplicationError } from "../models/http/applicationError";

export const parseApplicationError = (httpError : HttpErrorResponse ) : ApplicationError => {
  return new ApplicationError(httpError.error.status, httpError.error.type, httpError.error.title, httpError.error.traceId);
}