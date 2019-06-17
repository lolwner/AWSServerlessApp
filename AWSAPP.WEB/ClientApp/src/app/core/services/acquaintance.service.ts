import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { AcquaintanceResponseModel } from '../models/acquaintance-response-model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable()
export class AcquaintanceService {
    constructor(private http: HttpClient) { }

    private url = environment.apiRootUrl + "Acquaintance";

    getAcquaintancies(): Observable<AcquaintanceResponseModel>{
        return this.http.get<AcquaintanceResponseModel>(this.url)

    }
}