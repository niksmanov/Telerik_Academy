function solve() {

    return function (selector) {
        let template = `
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
        
        $(selector).html(template);
    };
}

module.exports = solve;