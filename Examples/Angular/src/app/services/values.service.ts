﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated with KY.Generator 3.3.0.0
//      Manual changes to this file may cause unexpected behavior in your application.
//      Manual changes to this file will be overwritten if the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
// tslint:disable

import { Value } from "../models/value";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Subject } from "rxjs";

@Injectable({
    providedIn: "root"
})
export class ValuesService {
    private readonly http: HttpClient;
    public serviceUrl: string = "";

    public constructor(http: HttpClient) {
        this.http = http;
    }

    public get(httpOptions: {} = undefined): Observable<string[]> {
        let subject = new Subject<string[]>();
        this.http.get<string[]>(this.serviceUrl + "/Values", httpOptions).subscribe(result => {
            const list: string[] = [];
            for (const entry of result) {
            list.push(<string>entry);
            }
            subject.next(list);
            subject.complete();
        }, error => subject.error(error));
        return subject;
    }

    public get2(id: number, httpOptions: {} = undefined): Observable<Value> {
        let subject = new Subject<Value>();
        this.http.get<Value>(this.serviceUrl + "/Values?id=" + this.convertAny(id), httpOptions).subscribe(result => {
            const model: Value = result === null || result === undefined ? undefined : new Value(result);
            subject.next(model);
            subject.complete();
        }, error => subject.error(error));
        return subject;
    }

    public post(value: Value, httpOptions: {} = undefined): Observable<void> {
        let subject = new Subject<void>();
        this.http.post<void>(this.serviceUrl + "/Values", value, httpOptions).subscribe(() => {
            subject.next();
            subject.complete();
        }, error => subject.error(error));
        return subject;
    }

    public put(id: number, value: Value, httpOptions: {} = undefined): Observable<void> {
        let subject = new Subject<void>();
        this.http.put<void>(this.serviceUrl + "/Values?id=" + this.convertAny(id), value, httpOptions).subscribe(() => {
            subject.next();
            subject.complete();
        }, error => subject.error(error));
        return subject;
    }

    public delete(id: number, httpOptions: {} = undefined): Observable<void> {
        let subject = new Subject<void>();
        this.http.delete<void>(this.serviceUrl + "/Values?id=" + this.convertAny(id), httpOptions).subscribe(() => {
            subject.next();
            subject.complete();
        }, error => subject.error(error));
        return subject;
    }

    public convertAny(value: any): string {
        return value === null || value === undefined ? "" : value.toString();
    }
}