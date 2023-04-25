<template>
  <LetterBase class="shadow-5" style="font-weight: bold;" :char="props.letter.char" :color="props.letter.color"></LetterBase>
</template>
<style>
.shadow-5 {
  background: linear-gradient(to-right, #4facfe 50%, #00f2fe 100%);
}
</style>

<script setup lang="ts">
import type { Letter } from '@/scripts/letter'
import LetterBase from './LetterBase.vue'

export interface Props {
  letter: Letter
}

const props = defineProps<Props>()
</script>
