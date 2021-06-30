module.exports = {
    purge: [
        './Client/**/*.{razor,html}'
    ],
    mode: 'jit',
    darkMode: 'media',
    theme: {
        extend:
        {
            fontFamily: {
                'sans': ["Helvetica Neue", "Helvetica", "Arial", "sans-serif"]
            }
        }
    }
}