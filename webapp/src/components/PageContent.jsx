import { useState, useEffect } from 'react';
import axios from '../api/axios';

import { Pagination, Typography, Flex } from 'antd';

import { useDataFetch } from '../context/DataFetchContext';

import LoadPage from './LoadPage';
import ErrorPage from './ErrorPage';

import CreateProductButton from './CreateProductButton';
import ProductsGrid from './ProductsGrid';

const { Title, Text } = Typography;

const PageContent = ({ pageWidth }) => {
    const { state, dispatch } = useDataFetch();

    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(null);
    const [productsCount, setProductsCount] = useState(null);

    // Изменение количества элементов на странице при изменении ширины страницы
    useEffect(() => {
        if (pageSize == null) {
            // Выставление базового значения количества элементов
            var pageSizes = getPageSizeOptions();
            setPageSize(pageSizes[0]);
        }
        else {
            // Пересчет при изменении ширины страницы
            var pageSizes = getPageSizeOptions();

            // Получение минимального расстояния между количеством возможных элементов и текущим значением
            var pageSizesDiff = pageSizes.map(size => Math.abs(size - pageSize));
            var minSizeDiff = Math.min(...pageSizesDiff);
            var minSizeDiffIndex = pageSizesDiff.indexOf(minSizeDiff);

            setPageSize(pageSizes[minSizeDiffIndex]);
            dispatch({ type: 'TOGGLE_FETCH' });

            // По хорошему, надо ререндерить страницу только, когда ширина меняется дальше, чем брейкпоинты :/
        }
    }, [pageWidth]);

    // Ререндер карточек при запросах на перезагрузку
    useEffect(() => {
        if (state.isDataFetchActive && pageSize != null) {
            fetchDataAsync();
            dispatch({ type: 'TOGGLE_FETCH' });
        }
    }, [state.isDataFetchActive, pageSize]);

    // Получение данных
    const fetchDataAsync = async () => {
        try {
            setLoading(true);
            setError(null);

            console.log(`Запрос списка товаров`);
            const response = await axios.get(`/api/products`, {
                params: {
                    "page": page,
                    "pageSize": pageSize
                },
            });
            console.log(response);

            setData(response.data.products);
            setProductsCount(response.data.productsCount);
        }
        catch (error) {
            console.error(error);

            switch (error.code) {
                case "ERR_NETWORK":
                    setError("Не удалось подключиться к серверу");
                    break;
                default:
                    setError(error.message);
            }
        }
        finally {
            setLoading(false);
        }
    };

    // Получение количества элементов на страницу
    const getPageSizeOptions = () => {
        var multiplier = 1;
        var rows = [3, 5, 15, 30];

        if (pageWidth <= 950)
            multiplier = 1;
        else if (pageWidth <= 1440)
            multiplier = 2;
        else if (pageWidth <= 2400)
            multiplier = 3;
        else
            multiplier = 5;

        return rows.map(row => row * multiplier);
    };

    // Обработчик изменения значений в пагинаторе
    const onShowChange = (page, pageSize) => {
        setPage(page);
        setPageSize(pageSize);
        dispatch({ type: 'TOGGLE_FETCH' });
    };

    // Основная часть
    const ProductsPage = () => {
        if (productsCount === 0)
            return (<Text style={{ fontSize: 18 }}>Товаров нет</Text>);

        return (<ProductsGrid productsData={data} />);
    };

    if (loading) return <LoadPage pageSize={pageSize} />;

    if (error) return <ErrorPage error={error} />;

    return (
        <>
            <Flex justify="space-between" className="page-title">
                <Title>Список товаров</Title>
                <CreateProductButton />
            </Flex>
            <ProductsPage />
            <Pagination
                align="center"
                showSizeChanger
                onChange={onShowChange}
                current={page}
                pageSize={pageSize}
                pageSizeOptions={getPageSizeOptions()}
                total={productsCount}
            />
        </>
    );
};

export default PageContent;