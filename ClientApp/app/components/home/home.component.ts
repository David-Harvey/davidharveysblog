import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})

export class HomeComponent {

    private http: Http;
    private originUrl: string; 
    public blogs: Blog[];
    public currentBlog: Blog;
    
    constructor(http: Http, @Inject('ORIGIN_URL') originUrl: string) {

        this.http = http;
        this.originUrl = originUrl;

        http.get(originUrl + '/api/blog/fetch').subscribe(result => {

            this.blogs = result.json() as Blog[];

            if (this.blogs.length > 0) {
                this.currentBlog = this.blogs[0];
            }
        });
    }

    setCurrentBlog(id : string, event: Event) {
        this.http.get(this.originUrl + '/api/blog/fetchblog/' + id).subscribe(result => {
            this.currentBlog = result.json() as Blog;
        });

        event.preventDefault();
    }
}

interface Blog {
    ID: string;
    Title: string;
    Description: string;
    Content: string;
    Created: Date;
}
