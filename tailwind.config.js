const colors = require('tailwindcss/colors')

module.exports = {
    purge: [
        './Client/**/*.{razor,html}'
    ],
    mode: 'jit',
    darkMode: 'media',
    theme: {
        extend: {
            colors: {
                primary: colors.blue,
                secondary: colors.amber,
                accent: colors.lime
            },
            keyframes: {

            },
            animation: {
            },
            screens: {
                'no-hover': { 'raw': '(hover:none)' }
            },
            fontFamily: {
                'sans': ["Helvetica Neue", "Helvetica", "Arial", "sans-serif"]
            }
        },
    },
    plugins: [],
}