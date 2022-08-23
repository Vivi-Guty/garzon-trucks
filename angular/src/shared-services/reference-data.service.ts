import { Injectable } from '@angular/core';
import { MasterData } from 'src/app/models/MasterData';
import { ApiService } from './api.service';

@Injectable({
    providedIn: 'root'
})
export class ReferenceDataService {

    constructor(private api: ApiService) { }
    private promises: any = {};

    // expira por defecto la promesa a los 30 min.
    private get<T>(relativeUrl: string, expires = 1800000): Promise<T> {
        let promise = this.promises[relativeUrl];
        if (!promise) {
            promise = this.promises[relativeUrl] = this.api.get(`reference-data/${relativeUrl}`);
            promise.then(() => {
                setTimeout(() => {
                    this.promises[relativeUrl] = undefined;
                }, expires)
            }).catch(() => {
                this.promises[relativeUrl] = undefined;
            });
        }
        return promise;
    }

    getMasterData(): Promise<MasterData[]> {
        return this.get('master-data');
    }
}
