import { Injectable } from '@angular/core';
import { TextModel } from 'src/app/models/TextModel';
import { ApiService } from './api.service';

@Injectable({
    providedIn: 'root'
})
export class TextService {

    public texts: TextModel[] = [];

    constructor(private api: ApiService) { }
    private promises: any = {};

    // expira por defecto la promesa a los 30 min.
    private get<T>(languageCode: string, expires = 1800000): Promise<T> {
        let relativeUrl = `texts?languageCode=${languageCode}`;
        let promise = this.promises[relativeUrl];
        if (!promise) {
            promise = this.promises[relativeUrl] = this.api.get(relativeUrl);
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

    getTexts(languageCode: string): Promise<TextModel[]> {
        return this.get(languageCode);
    }
}
