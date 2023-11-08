import { HttpClient, HttpContext, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { environment } from 'src/environments/environment';

export interface RequestOptions {
  headers?: HttpHeaders | {
      [header: string]: string | string[];
  };
  context?: HttpContext;
  params?: HttpParams | {
      [param: string]: string | number | boolean | ReadonlyArray<string | number | boolean>;
  };
  reportProgress?: boolean;
}

interface HttpRequestOptions extends RequestOptions {
  body?: any;
  context?: HttpContext;
  observe?: 'body' | 'events' | 'response';
  responseType?: 'arraybuffer' | 'blob' | 'json' | 'text';
  withCredentials?: boolean
}
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getApiUrl(relativeUrl: string): string {
    const baseUrl = environment.apiBaseUrl;
    const url = `${baseUrl}/${relativeUrl}`;
    return url;
  }

  private async request(method: string, relativeUrl: string, options: HttpRequestOptions): Promise<any> {
    const op = options || {};
    const $ = this.http.request(method, this.getApiUrl(relativeUrl), options);
    return lastValueFrom($);
  }

  private requestJson<T>(method: string, relativeUrl: string, body?: any, options?: RequestOptions): Promise<T> {
    const op = Object.assign({observe: 'body', responseType: 'json', body}, options) as HttpRequestOptions;
    return this.request(method, relativeUrl, op);
  }

  private requestBlob(method: string, relativeUrl: string, body?: any, options?: RequestOptions): Promise<Blob> {
    const op = Object.assign({observe: 'body', responseType: 'blob', body}, options) as HttpRequestOptions;
    return this.request(method, relativeUrl, op);
  }

  get<T>(relativeUrl: string, options?: RequestOptions): Promise<T> {
    return this.requestJson('GET', relativeUrl, undefined, options);
  }

  post<T>(relativeUrl: string, body?: any, options?: RequestOptions): Promise<T> {
    return this.requestJson('POST', relativeUrl, body, options)
  }

  delete<T>(relativeUrl: string, options?: RequestOptions): Promise<T> {
    return this.requestJson('DELETE', relativeUrl, undefined, options);
  }

  getBlob(relativeUrl: string, options?: RequestOptions): Promise<Blob> {
    return this.requestBlob('GET', relativeUrl, undefined, options);
  }

  postBlob(relativeUrl: string, body: any, options?: RequestOptions): Promise<Blob> {
    return this.requestBlob('POST', relativeUrl, body, options);
  }
}
