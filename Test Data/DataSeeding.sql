Delete From Blogs;

Insert Into Blogs (ID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Title, Description, Content)
Values
(
	NEWID(),
	'David Harvey',
	'2017-05-28 19:26:28',
	'David Harvey',
	'2017-05-28 19:26:28',
	'Hello World!',
	'Are we live yet? Anyone... someone...',
	'
Welcome to my first blog post. This blog aims to be inspiring to some, knowledgeable to others, and easy to follow with some light reading.

I built this blog using a couple of relatively new technologies to prove to myself that I could do it. It has been built with mainly Asp.Net Core 1.1, Angular2 and Entity framework. 

I realise this isn''t much of a blog yet, but the idea is to build on it, and hopefully and eventually pass on some tutorials, patterns and solutions to niggles that I''ve managed to solve.

A couple of shout outs to patterns and packages I''ve used:

- [MarkdownToHtml](https://www.npmjs.com/package/markdown-to-html-pipe "MarkdownToHtml") - A great package which allowed me to write this blog entry in Markdown, and transform it into HTML.
- [TruelyGenericRepository](https://cpratt.co/truly-generic-repository/) - A great example of building a generic repository pattern for entities using Code First.

Next up: Transitioning from traditional .NET to .NET Core 1.1, and using ASP.NET Core.'
);

Insert Into Blogs (ID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Title, Description, Content)
Values
(
	NEWID(),
	'David Harvey',
	'2017-05-29 19:26:28',
	'David Harvey',
	'2017-05-29 19:26:28',
	'Dummy entry 2 - Title',
	'Dummy Entry 2 - Description',
	'# Hello! This is dummy entry 2  
	 Alot more content to come, not quite finished yet.
	'
);

Insert Into Blogs (ID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Title, Description, Content)
Values
(
	NEWID(),
	'David Harvey',
	'2017-05-30 19:26:28',
	'David Harvey',
	'2017-05-30 19:26:28',
	'Dummy entry 3 - Title',
	'Dummy Entry 3 - Description',
	'# Hello! This is dummy entry 3  
	 Alot more content to come, not quite finished yet.
	'
);

Insert Into Blogs (ID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Title, Description, Content)
Values
(
	NEWID(),
	'David Harvey',
	'2017-05-31 19:26:28',
	'David Harvey',
	'2017-05-31 19:26:28',
	'Dummy entry 4 - Title',
	'Dummy Entry 4 - Description',
	'# Hello! This is dummy entry 4  
	 Alot more content to come, not quite finished yet.
	'
);

Insert Into Blogs (ID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, Title, Description, Content)
Values
(
	NEWID(),
	'David Harvey',
	'2017-05-31 20:26:28',
	'David Harvey',
	'2017-05-31 20:26:28',
	'Dummy entry 5 - Title',
	'Dummy Entry 5 - Description',
	'# Hello! This is dummy entry 5  
	 Alot more content to come, not quite finished yet.
	'
);
