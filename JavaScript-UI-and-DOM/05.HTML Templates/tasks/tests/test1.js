const data = {
    headers: ['Vendor', 'Model', 'OS'],
    items: [{
        col1: 'Nokia',
        col2: 'Lumia 920',
        col3: 'Windows Phone'
    }, {
        col1: 'LG',
        col2: 'Nexus 5',
        col3: 'Android'
    }, {
        col1: 'Apple',
        col2: 'iPhone 6',
        col3: 'iOS'
    }]
};

//Handlebars Template (here we generate the code)
const hbTemplate = `
<table class="items-table"> 
<thead>
<tr>
<th>#</th>
{{#headers}}
<th>{{this}}</th>
{{/headers}}
</tr>
<tbody>
<tr>
{{#items}}
<td>{{@index}}</td>
<td>{{col1}}</td>
<td>{{col2}}</td>
<td>{{col3}}</td>
</tr>
{{/items}}
</tbody>
`;

//compile the Handlebars template through function which waits for information and generates HTML
let template = Handlebars.compile(hbTemplate);

//get HTML element which will display the information from Handlebars template
document.getElementById('container').innerHTML = template(data);