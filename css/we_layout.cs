@charset "utf-8";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 2
   Review Assignment
   
   TSS Layout Styles
   Filename: tss_layout.css

*/
main{
	display: grid;
	overflow: hidden;
	grid-template-columns: auto auto auto auto;
	gap: 20px;
	background-color: silver;
	
}

body {
	margin: 0;
	width: 100%;
	max-width: 1300px;
	min-width: 640px;
}

body > header {
	margin: 0;
	padding: 0px;
	width: 100%;
	overflow: hidde;
}

body > header > img {
	margin: 0px;
	padding: 0px;
}

body > nav {
	width: 8%;
	float: left;
	margin: 0 0 0 2%;
	background-color:;
	font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
	font-weight: bold;
}

body >  {
	
}

body > section#tss_coaches > aside {
	float: right;
	width: 5%;
}


body > section#tss_coaches > article.coach_bio img {
	float: left;
	width: 30%;
	margin: 5px 20px 10px 0px;
}

article.coach_bio {
	clear: left;
}

body > footer {
	width: 100%;
	clear: left;
}
