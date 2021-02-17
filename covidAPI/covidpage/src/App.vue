<template>
  <div id="app">
   <div class="container">
	<table>
		<thead>
			<tr>
				<th>Pais</th>
				<th>Ranking</th>
				<th>Total De Casos</th>
			</tr>
		</thead>
		<tbody>
			<tr v-for="p in paises" :key="p.id" > 
				<td>{{p.country}}}</td>
				<td>{{p.index}}</td>
				<td>{{p.totalConfirmed - p.totalRecovered}}</td>
			
			</tr>
		</tbody>
	</table>
</div>


  </div>
</template>

<script>
import Axios from "axios";
export default {
  name: "App",
  components: {
  
  },
  data() {
    return {
      paises: "",
    };
  },
  mounted() {
    let context = this;
    Axios.get("https://localhost:44318/covid19")
      .then((resp) => {
        context.paises = resp;
      })
      .catch((erro) => {
        console.log(erro);
        alert("Erro ao carrega os dados");
      });
  },
};
</script>

<style>
* {
  margin: 0;
  pading: 0;
  box-sizing: border-box;
}
body {
  background-color: rgb(63, 72, 83);
  font-family: sans-serif;
  color: rgb(220, 220, 220);
  padding: 50px;
  width: 100vw;
  overflow-x: hidden;
}
h1 {
  font-weight: 400;
}
a {
  color: inherit;
}
p {
  margin-top: 0.7em;
}
.warning {
  color: rgb(62, 148, 236);
}
.st_viewport {
  max-height: 500px;
  overflow: auto;
}

[data-table_id="1"] {
  background-color: rgb(255, 115, 0);
}
[data-table_id="2"] {
  background-color: rgb(61, 53, 39);
  color: rgb(220, 220, 220);
}
[data-table_id="3"] {
  background-color: rgba(168, 189, 4, 0.8);
}

._rank {
  min-width: 80px;
}
._id {
  min-width: 60px;
}
._name {
  min-width: 130px;
}
._surname {
  min-width: 130px;
}
._year {
  min-width: 80px;
}
._section {
  min-width: 130px;
}

pre {
  overflow: auto;
}

/** Sticky table styles **/
.st_viewport {
  background-color: rgb(62, 148, 236);
  color: rgb(27, 30, 36);
  margin: 20px 0;
}
/* ###  Table wrap */
.st_wrap_table {
}
/* ##   header */
.st_table_header {
  position: -webkit-sticky;
  position: sticky;
  top: 0px;
  z-index: 1;
  background-color: rgb(27, 30, 36);
  color: rgb(220, 220, 220);
}
.st_table_header h2 {
  font-weight: 400;
  margin: 0 20px;
  padding: 20px 0 0;
}
.st_table_header .st_row {
  color: rgba(220, 220, 220, 0.7);
}
.st_table_header .st_column {
}
/* ##  table */
.st_table {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
  -webkit-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
}
/* #   row */
.st_row {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  margin: 0;
}
.st_table .st_row:nth-child(even) {
  background-color: rgba(0, 0, 0, 0.1);
}
/* #   column */
.st_column {
  padding: 10px 20px;
}
</style>
