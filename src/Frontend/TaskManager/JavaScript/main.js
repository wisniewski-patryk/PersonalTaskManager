const addElementBtn = document.getElementById('add-element');

		addElementBtn.addEventListener('click', addElement);

		function addElement() {
			// Utwórz nowy element HTML reprezentujący kwadrat
			const newElement = document.createElement('div');
			newElement.id = 'element';

			// Dodaj obsługę zdarzenia mousedown na kwadracie, aby umożliwić przesuwanie go po stronie
			newElement.addEventListener('mousedown', function(e) {
				let positionX = e.clientX;
				let positionY = e.clientY;

				function moveElement(e) {
					let newPositionX = positionX - e.clientX;
					let newPositionY = positionY - e.clientY;

					positionX = e.clientX;
					positionY = e.clientY;

					newElement.style.top = (newElement.offsetTop - newPositionY) + 'px';
					newElement.style.left = (newElement.offsetLeft - newPositionX) + 'px';
				}

				document.addEventListener('mousemove', moveElement);

				document.addEventListener('mouseup', function() {
					document.removeEventListener('mousemove', moveElement);
				});
			});

			// Dodaj nowo utworzony kwadrat do strony
			document.body.appendChild(newElement);
		}