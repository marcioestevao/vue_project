<template>
  <div>
    <titulo texto="Professores" />
    <table>
      <thead>
        <th>Código</th>
        <th>Nome</th>
        <th>Alunos</th>
      </thead>
      <tbody v-if="Professores.length">
        <tr v-for="(professor, index) in Professores" :key="index">
          <td>{{ professor.id }}</td>
          <router-link to="/alunos" tag="td" style="cursor: pointer">
            {{ professor.nome }} {{ professor.sobrenome }}
          </router-link>
          <td>
            {{ professor.qtdAlunos }}
          </td>
        </tr>
      </tbody>
      <tfoot v-else>
        Nenhum professor encontrado
      </tfoot>
    </table>
  </div>
</template>

<script>
import Titulo from "../_share/Titulo";

export default {
  components: {
    Titulo,
  },

  data() {
    return {
      Alunos: [],
      Professores: [
        // { id: 1, nome: "Vinicius" },
        // { id: 2, nome: "Marcio" },
        // { id: 3, nome: "Larissa" },
      ],
    };
  },
  created() {
    this.$http
      .get("http://localhost:3000/alunos")
      .then((res) => res.json())
      .then((alunos) => {
        this.Alunos = alunos;
        this.carregarProfessores();
      });
  },
  props: {},
  methods: {
    pegarQtdAlunosPorProfessor() {
      this.Professores.forEach((professor, index) => {
        professor = {
          id: professor.id,
          nome: professor.nome,
          qtdAlunos: this.Alunos.filter(
            (aluno) => aluno.professor.id == professor.id
          ).length,
        };

        this.Professores[index] = professor;
      });
    },

    carregarProfessores() {
      this.$http
        .get("http://localhost:3000/professores")
        .then((res) => res.json())
        .then((professores) => {
          this.Professores = professores;
          this.pegarQtdAlunosPorProfessor();
        });
    },
  },
};
</script>

<style lang="scss" scoped>
</style>