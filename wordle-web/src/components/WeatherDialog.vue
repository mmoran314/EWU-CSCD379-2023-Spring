<template>
    <v-btn @click="isDialogOpen = !isDialogOpen">Weather</v-btn>
    <v-dialog v-model="isDialogOpen">
    <v-card>
        <v-card-title>Weather</v-card-title>

    </v-card>
    </v-dialog> 
</template>



<script setup lang ="ts">
import { ref } from 'vue'
const isDialogOpen = ref(false)
</script>