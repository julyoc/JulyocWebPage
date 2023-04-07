/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [ "**/*.{razor,html,cshtml}", "./node_modules/tw-elements/dist/js/**/*.js" ],
  theme: {
      extend: {
          colors: {
              'primary-2': '#1E3D83',
              'primary-1': '#2B3858',
              'primary': '#061947',
              'primary+1': '#3C5EAB',
              'primary+2': '#4D69AB',
              'secondary1-2': '#382087',
              'secondary1-1': '#372C5B',
              'secondary1': '#160649',
              'secondary1+1': '#593EAD',
              'secondary1+2': '#654FAD',
              'secondary2-2': '#107676',
              'secondary2-1': '#214F4F',
              'secondary2': '#034040',
              'secondary2+1': '#2DA1A1',
              'secondary2+2': '#3EA1A1',
              'complementary-2': '#C48C1B',
              'complementary-1': '#846A38',
              'complementary': '#6A4805',
              'complementary+1': '#D7A33B',
              'complementary+2': '#D7AB53'
          },
          fontFamily: {
              'LaBelleAurore': 'LaBelleAurore',
              'EastSeaDokdo': 'EastSeaDokdo'
          }
      },
  },
    plugins: [
        require("tw-elements/dist/plugin")
    ],
}
